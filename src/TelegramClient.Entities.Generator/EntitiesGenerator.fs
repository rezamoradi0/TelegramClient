module EntitiesGenerator

open Models

open System
open System.Collections.Generic
open System.IO

let defaultNamespace = "TelegramClient.Entities"

let outFodler = ".generated"

let getShotNamespace (tlType: TlType) = 
    ""
    
let getClassName (tlType: TlType, interfacesHash: HashSet<string>) = 
    ""

let getShotNamespace (tlType: TlType) = 
    ""
let createFile (tlType: TlType, interfacesHash: HashSet<string>) = 
    let nmsp = getShotNamespace(tlType)
    let className = getClassName(tlType, interfacesHash)

    let path = Path.Combine(outFodler, ,
    ()

let isInterface (schema : Schema) (tlType: TlType) =
    let lenght = schema.Types
                |> Seq.filter(fun t -> t.Type = tlType.Type)
                |> Seq.length
    lenght > 1

let generateEntities (schema: Schema) = 
    let typeTemplate = File.ReadAllText("Type.tmp");
    let methodTemplate = File.ReadAllText("Method.tmp");

    let interfacesHash = new HashSet<string>()
    let typesList = schema.Types
                    |> Seq.map(fun t -> t.Type)
                    |> List.ofSeq

    for tlType in schema.Types do
        if isInterface schema tlType then
            interfacesHash.Add tlType.Type |> ignore
        
        createFile tlType

()