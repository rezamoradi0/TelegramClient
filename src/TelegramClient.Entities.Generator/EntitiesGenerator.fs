module EntitiesGenerator

open Models

open System
open System.Collections.Generic
open System.IO
open System.Text

let defaultNamespace = "TelegramClient.Entities"
let baseObjectInterface = "ITlObejct"

let outFodler = ".generated"

let namespaceMarker = "/* NAMESPACE */"

let constructorMarker = "/* CONSTRUCTOR */"

let nameMarker = "/* NAME */"

let parentMarker = "/* PARENT */"

let formatName (name: string) =
    name.Split('_')
    |> Seq.map(fun w -> 
        let firstChar = Seq.head w
                        |> Char.ToUpper
        String.Concat(firstChar, w.Substring(1))
        )
    |> String.Concat

let getClassNameFromEntity (typeName:string) = 
    let className =  typeName.Split('.')
                    |> Array.last
                    |> formatName

    className

let getClassNameFromInterface (typeName:string) = 
    let interfaceName =  typeName.Split('.')
                        |> Array.last
                        |> formatName
    "I" + interfaceName

let getClassNameFromMethod (tlMethod: TlMethod) = 
    let className =  tlMethod.Type.Split('.')
                    |> Array.last
                    |> formatName

    "Request" + className

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

let createFile (nmsp:string) (className: string) (content: string) = 
    let path = Path.Combine(outFodler, nmsp, className + ".cs")

    let dir = Path.GetDirectoryName path
    if Directory.Exists dir |> not  then
        Directory.CreateDirectory dir |> ignore

    if File.Exists path then
        File.Delete path

    File.WriteAllText(path, content, Encoding.UTF8)

let createEntityFile (className: string) =
    let nmsp = getShotNamespace(className)
    let className = getClassNameFromEntity(className)
    createFile nmsp className

let createInterafaceFile (interfaceName: string) =
    let nmsp = getShotNamespace(interfaceName)
    let className = getClassNameFromInterface(interfaceName)
    createFile nmsp className

let createRequestFile (tlMethod: TlMethod) =
    let nmsp = getShotNamespace(tlMethod.Type)
    let className = getClassNameFromMethod(tlMethod)
    createFile nmsp className

let getInterface (schema : Schema) (tlType: TlType) =
    let lenght = schema.Types
                |> Seq.filter(fun t -> t.Type = tlType.Type)
                |> Seq.length
    
    match lenght > 1 with
    | true -> Some()
    | _ -> None

let getParentForType (tlType: TlType, interfacesHash: HashSet<string>) =
    match interfacesHash.Contains tlType.Type with
    | true -> getClassNameFromEntity(tlType.Predicate)
    | false -> baseObjectInterface

let generateEntities (schema: Schema) = 
    let entityTemplate = File.ReadAllText("Entity.tmp");
    let requestTemplate = File.ReadAllText("Request.tmp");
    let interfaceTemplate = File.ReadAllText("Interface.tmp");

    let interfacesHash = new HashSet<string>()
    let typesList = schema.Types
                    |> Seq.map(fun t -> t.Type)
                    |> List.ofSeq

    for tlType in schema.Types do
        if getInterface schema tlType = Some() then
            interfacesHash.Add tlType.Type |> ignore

            StringBuilder(interfaceTemplate)
                .Replace(namespaceMarker, getFullNamespace(tlType.Type))
                .Replace(nameMarker, getClassNameFromInterface(tlType.Type))
                .ToString()
            |> createInterafaceFile tlType.Type

        StringBuilder(entityTemplate)
            .Replace(constructorMarker, tlType.Id)
            .Replace(parentMarker, getParentForType(tlType, interfacesHash))
            .Replace(namespaceMarker, getFullNamespace(tlType.Type))
            .Replace(nameMarker, getClassNameFromEntity(tlType.Predicate))
            .ToString()
        |> createEntityFile tlType.Type


        // use stream = createTypeFile tlType interfacesHash
        
    
    // for tlMethod in schema.Methods do
        // createMethodFile tlMethod
    
()
