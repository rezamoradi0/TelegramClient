module EntitiesGenerator

open Models

open System
open System.Collections.Generic
open System.IO
open System.Text

let defaultNamespace = "TelegramClient.Entities"
let baseObjectInterface = "ITlObejct"

let outFodler = ".generated"
let entitiesFodler = "_Entities"

let namespaceMarker = "/* NAMESPACE */"

let constructorMarker = "/* CONSTRUCTOR */"

let nameMarker = "/* NAME */"

let parentMarker = "/* PARENT */"
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

// let getClassNameFromMethod (tlMethod: TlMethod) = 
//      getName typeName
//     |> sprintf "Request%s"

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

let getParametersForEntity (prms: TlParam list) = 
    ""

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

let createEntityFile (className: string) (interfaceName) (interfacesHash: HashSet<string>)=
    let nmsp = getShotNamespace(className)
    let className = getClassNameFromEntity(className)

    match interfacesHash.Contains interfaceName with
    | true ->  getName interfaceName |> createFile nmsp className
    | false ->  createFile nmsp className String.Empty

let createInterafaceFile (typeName: string) =
    let nmsp = getShotNamespace(typeName)
    let interfaceName = getClassNameFromInterface(typeName)
    let name = getName typeName
    createFile nmsp interfaceName name

// let createRequestFile (tlMethod: TlMethod) =
//     let nmsp = getShotNamespace(tlMethod.Type)
//     let className = getClassNameFromMethod(tlMethod)
//     createFile nmsp className String.Empty

let IsInterface (schema : Schema) (tlType: TlType) (interfacesHash: HashSet<string>) =
    match interfacesHash.Contains(tlType.Type) with
    | true -> Some()
    | false -> 
        let lenght = schema.Types
                    |> Seq.filter(fun t -> t.Type = tlType.Type)
                    |> Seq.length

        match lenght > 1 with
        | true -> Some()
        | _ -> None

let getParentForType (tlType: TlType, interfacesHash: HashSet<string>) =
    match tlType.Type = tlType.Predicate with
    | true -> baseObjectInterface
    | false -> 
        match interfacesHash.Contains tlType.Type with
        | true -> getClassNameFromInterface(tlType.Type)
        | false -> baseObjectInterface

let generateEntities (schema: Schema) = 
    if Directory.Exists outFodler then
        Directory.Delete(outFodler, true)

    let entityTemplate = File.ReadAllText("Entity.tmp");
    let requestTemplate = File.ReadAllText("Request.tmp");
    let interfaceTemplate = File.ReadAllText("Interface.tmp");

    let interfacesHash = new HashSet<string>()
    let typesList = schema.Types
                    |> Seq.map(fun t -> t.Type)
                    |> List.ofSeq

    for tlType in schema.Types do
        if IsInterface schema tlType interfacesHash = Some() then
            interfacesHash.Add tlType.Type |> ignore
            StringBuilder(interfaceTemplate)
                .Replace(namespaceMarker, getFullNamespace(tlType.Type))
                .Replace(nameMarker, getClassNameFromInterface(tlType.Type))
                .ToString()
            |> createInterafaceFile tlType.Type

        StringBuilder(entityTemplate)
            .Replace(constructorMarker, tlType.Id)
            .Replace(parentMarker, getParentForType(tlType, interfacesHash))
            .Replace(namespaceMarker, getFullNamespace(tlType.Predicate))
            .Replace(nameMarker, getClassNameFromEntity(tlType.Predicate))
            .Replace(paramMarker, getParametersForEntity(tlType.Params))
            .ToString()
        |> createEntityFile tlType.Predicate tlType.Type interfacesHash


        // use stream = createTypeFile tlType interfacesHash
        
    
    // for tlMethod in schema.Methods do
        // createMethodFile tlMethod
    
()
