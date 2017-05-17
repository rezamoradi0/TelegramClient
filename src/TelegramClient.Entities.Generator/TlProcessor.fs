module TlProcessor

open Models
open System.Text.RegularExpressions

let isCommented (line: string) =
    match line.StartsWith("//") with
    | true -> Some()
    | false -> None

let isTypeRegion (line: string) =
    match line with
    | "---types---" -> Some(true)
    | "---functions---" -> Some(false)
    | _ -> None

let parseLine (line: string, schema: Schema) =
    let matches = Regex.Matches(line, "^([a-zA-Z\.\_]*)#([0-9a-z]*) (.*) = (.*);$")
    let groups = matches.Item(0).Groups
    groups.Item(0).Value, groups.Item(1).Value, groups.Item(2).Value, groups.Item(3).Value

let parseParams (line:string) =
    line.Split(' ')
    |> Seq.map(fun p -> 
        let prms = p.Split(':')
        { Name = prms.GetValue(0) :?> string; Type = prms.GetValue(1) :?> string}
    )

// let createType parseResult = 
//     let (name:string), (constr:string), (prms:string), (result:string) = parseResult
    


// let Parse (schema:string[]) =
//     let types = {new List<TlType>(); new List<TlMethod>()}

//     let mutable isType = true

//     for line in schema do
//         match isCommented line with
//         | Some(_) -> ()
//         | None -> 
//             match isTypeRegion line with
//             | Some(v) -> isType <- v
//             | None -> 
//                 let name, constr, prms, result = parseLine(line)
//                 match isType with