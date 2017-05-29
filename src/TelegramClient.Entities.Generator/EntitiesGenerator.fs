module EntitiesGenerator

open Models

open System
open System.Collections.Generic
open System.IO
open System.Text
open System.Text.RegularExpressions

let defaultNamespace = "TelegramClient.Entities"
let baseObjectInterface = "ITlObejct"

let outFodler = ".generated"
let entitiesFodler = "_Entities"

let namespaceMarker = "/* NAMESPACE */"

let constructorMarker = "/* CONSTRUCTOR */"
let requestParamMarker = "/* GENERIC_PARAM */"

let nameMarker = "/* NAME */"

let parentMarker = "/* PARENT */"
let serializeMarker = "/* SERIALIZE */"
let paramMarker = "/* PARAMS */"

let formatName (name: string) =
    name.Split('_')
    |> Seq.map(fun w -> 
        let firstChar = Seq.head w
                        |> Char.ToUpper
        String.Concat(firstChar, w.Substring(1))
        )
    |> String.Concat

let getName (name: string) = 
    name.Split('.')
    |> Array.last
    |> formatName

let getClassNameFromEntity (typeName:string) = 
    getName typeName

let getClassNameFromInterface (typeName:string) = 
    getName typeName
    |> sprintf "I%s"

let containsName (interfacesSet: HashSet<string>) (tlType:string) =
    tlType.ToLower() |> interfacesSet.Contains

let getShotNamespace (typeName: string) = 
    match typeName.Contains(".") with
    | false -> String.Empty
    | true -> 
        typeName.Split('.')
        |> Array.head
        |> formatName

let getFullNamespace (typeName: string) = 
    let shortNamespace = getShotNamespace typeName

    match String.IsNullOrWhiteSpace shortNamespace with
    | true -> defaultNamespace
    | false -> defaultNamespace + "." + shortNamespace

let genericTypeReg = Regex("(.*)\<(.*)\>")

let validTypes = HashSet [|"string"; "int"; "long"; "long"; "double"|]

let rec typeMapping (typeSet: HashSet<string>) (tlType:string) = 
    match tlType with
    | ltType when validTypes.Contains(tlType.ToLower()) -> tlType
    | "vector" -> "Vector"
    | "int128" -> "byte[]"
    | "int256" -> "byte[]"
    | "bytes" -> "byte[]"
    | "#" -> "BitArray"
    | "Bool" -> "bool"
    | "true" -> "bool"
    | tlType when containsName typeSet tlType -> formatName tlType
    | tlType when genericTypeReg.IsMatch(tlType) -> 
        let group = genericTypeReg.Match(tlType).Groups
        
        let genericClass =  group.Item(1).Value |> typeMapping typeSet
        let genericParameter =  group.Item(2).Value |> typeMapping typeSet

        sprintf "%s<%s>" genericClass genericParameter
    | tlType when tlType.Contains("?")-> 
        tlType.Split('?')
        |> Array.last
        |> typeMapping typeSet
    | _ -> tlType


let expressionReg = Regex(@"(\w*)\.(\d\d?)\?(\w*)")

let getSerializeAttribute(tlParam: TlParam) =
    match tlParam.Type.Contains("?") with
    | false -> None
    | true -> 
        let group = expressionReg.Match(tlParam.Type)
        let fieldName = group.Groups.Item(1).Value |> formatName
        let index = group.Groups.Item(2).Value
        let resultType = group.Groups.Item(3).Value
        
        match resultType with
        | "true" -> sprintf """       [FromFlag("%s", %s)]""" fieldName index |> Some
        | _ -> sprintf """       [CanSerialize("%s", %s)]""" fieldName index |> Some

let getParametersForEntity (typeSet: HashSet<string> , prms: TlParam list) = 
    let result = List<string>()
    prms
    |> Seq.ofList
    |> Seq.iteri(fun i p ->
        let paramType = typeMapping typeSet p.Type
        let paramName = formatName p.Name

        sprintf "       [SerializationOrder(%i)]" i |> result.Add
        
        match getSerializeAttribute p with
        | Some(value) -> result.Add value
        | None -> ()

        sprintf "       public %s %s {get; set;}\n" paramType paramName |> result.Add
    )

    result |> String.concat "\n"

let createFile (nmsp:string) (className: string) (interfaceFolder: string) (content: string) = 
    let nmsp =  match String.IsNullOrEmpty(nmsp) with
                | true -> entitiesFodler
                | false -> nmsp

    let path = Path.Combine(outFodler, nmsp, interfaceFolder, className + ".cs")

    let dir = Path.GetDirectoryName path
    if Directory.Exists dir |> not  then
        Directory.CreateDirectory dir |> ignore

    if File.Exists path then
        File.Delete path

    File.WriteAllText(path, content, Encoding.UTF8)

let createEntityFile (tlType: TlType) (interfacesHash: HashSet<string>)=
    let nmsp = getShotNamespace(tlType.Predicate)
    let className = getClassNameFromEntity(tlType.Predicate)

    match containsName interfacesHash tlType.Type with
    | true ->  getName tlType.Type |> createFile nmsp className
    | false ->  createFile nmsp className String.Empty

let createInterfaceFile (typeName: string) =
    let nmsp = getShotNamespace(typeName)
    let interfaceName = getClassNameFromInterface(typeName)
    let name = getName typeName
    createFile nmsp interfaceName name

let getParentForType (tlType: TlType, interfacesSet: HashSet<string>) =
    match tlType.Type = tlType.Predicate with
    | true -> baseObjectInterface
    | false -> 
        match containsName interfacesSet tlType.Type with
        | true -> getClassNameFromInterface(tlType.Type)
        | false -> baseObjectInterface


let getClassNameFromRequest (tlRequest: TlRequest) = 
     getName tlRequest.Method
    |> sprintf "Request%s"

let getGenericParamRequest (tlRequest: TlRequest, interfacesSet: HashSet<string>) = 
    let name = getName tlRequest.Type
    match containsName interfacesSet name with
    | true -> getClassNameFromInterface(tlRequest.Type)
    | false -> name

let getFileNameFromRequest (tlRequest: TlRequest) = 
    let className = getClassNameFromRequest tlRequest
    className.Replace("<", "").Replace(">", "")
    
let createRequestFile (tlMethod: TlRequest) (interfacesHash: HashSet<string>) =
    let nmsp = getShotNamespace(tlMethod.Type)
    let fileName = getFileNameFromRequest(tlMethod)

    match containsName interfacesHash tlMethod.Type with
    | true ->  getName tlMethod.Type |> createFile nmsp fileName
    | false ->  createFile nmsp fileName String.Empty

let generateEntities (schema: Schema) = 
    if Directory.Exists outFodler then
        Directory.Delete(outFodler, true)

    let entityTemplate = File.ReadAllText("Entity.tmp");
    let requestTemplate = File.ReadAllText("Request.tmp");
    let interfaceTemplate = File.ReadAllText("Interface.tmp");

    let interfacesHash = new HashSet<string>()
    let typesHash = schema.Types
                    |> Seq.map(fun t -> t.Predicate.ToLower())
                    |> HashSet<string>
    schema.Types
    |> Seq.map(fun t -> t.Type)
    |> Seq.forall(fun t -> 
            let name = t.ToLower()
            name |>  interfacesHash.Add |> ignore
            name |> typesHash.Add |> ignore
            true
        )
    |> ignore

    for tlType in schema.Types do
        if containsName interfacesHash tlType.Type then
            StringBuilder(interfaceTemplate)
                .Replace(namespaceMarker, getFullNamespace(tlType.Type))
                .Replace(nameMarker, getClassNameFromInterface(tlType.Type))
                .ToString()
            |> createInterfaceFile tlType.Type

        StringBuilder(entityTemplate)
            .Replace(constructorMarker, tlType.Id)
            .Replace(parentMarker, getParentForType(tlType, interfacesHash))
            .Replace(namespaceMarker, getFullNamespace(tlType.Predicate))
            .Replace(nameMarker, getClassNameFromEntity(tlType.Predicate))
            .Replace(paramMarker, getParametersForEntity(typesHash, tlType.Params))
            .ToString()
        |> createEntityFile tlType interfacesHash

    for tlRequest in schema.Requests do
     StringBuilder(requestTemplate)
            .Replace(constructorMarker, tlRequest.Id)
            .Replace(namespaceMarker, getFullNamespace(tlRequest.Method))
            .Replace(requestParamMarker, getGenericParamRequest(tlRequest, interfacesHash))
            .Replace(nameMarker, getClassNameFromRequest(tlRequest))
            .Replace(paramMarker, getParametersForEntity(typesHash, tlRequest.Params))
            .ToString()
        |> createRequestFile tlRequest interfacesHash
    
()
