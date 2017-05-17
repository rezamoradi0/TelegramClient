module TlProcessor

open System
open System.Collections.Generic;
open Models
open System.Text.RegularExpressions
let private isCommented (line: string) =
    match line.StartsWith("//") with
    | true -> Some()
    | false -> None

let private isTypeRegion (line: string) =
    match line with
    | "---types---" -> Some(true)
    | "---functions---" -> Some(false)
    | _ -> None

let private parseLine (line: string) =
    let matches = Regex.Matches(line, @"^([a-zA-Z\\.\\_0-9]*)#([0-9a-z]*)[ ]?(.*) = (.*);$")
    let groups = matches.Item(0).Groups
    groups.Item(1).Value, groups.Item(2).Value, groups.Item(3).Value, groups.Item(4).Value

let private parseParams (line:string) =
    match String.IsNullOrWhiteSpace line with 
    | true -> Seq.empty
    | false -> 
        line.Split(' ')
        |> Seq.map(fun p -> 
            let prms = p.Split(':')
            match prms.Length with
            | 1 -> { Name = line; Type = line;}
            | _ -> { Name = prms.GetValue(0) :?> string; Type = prms.GetValue(1) :?> string}
            )

let private createMethod parseResult = 
    let (sName:string), (sConstr:string), (sPrms:string), (sResult:string) = parseResult
    let prms = parseParams sPrms
            |> Seq.toList
    {Id = Convert.ToInt32(sConstr, 16); Method = sResult; Params = prms; Type = sName }

let private createType parseResult = 
    let (sName:string), (sConstr:string), (sPrms:string), (sResult:string) = parseResult
    let prms =  parseParams sPrms
                |> Seq.toList
    {Id = Convert.ToInt32(sConstr, 16); Predicate = sResult; Params = prms; Type = sName }

let parseTlSchema (lines: string seq) =
    let schema = {Types = new List<TlType>(); Methods = new List<TlMethod>()}

    let mutable isType = true

    for line in lines do
        match String.IsNullOrWhiteSpace line with
        | true -> ()
        | false -> 
            match isCommented line with
            | Some(_) -> ()
            | None -> 
                match isTypeRegion line with
                | Some(v) -> isType <- v
                | None -> 
                    match isType with
                    | true -> 
                        parseLine(line) 
                        |> createType
                        |> schema.Types.Add
                    | false -> 
                        parseLine(line) 
                        |> createMethod
                        |> schema.Methods.Add
    schema