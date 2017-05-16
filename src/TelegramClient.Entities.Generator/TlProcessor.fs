module TlProcessor

open Models
open System.Text.RegularExpressions

let isCommented (line: string) =
    match line.StartsWith("//") with
    | true -> Some()
    | false -> None

let isNotCommented (line: string) =
    match line.StartsWith("//") with
    | true -> Some()
    | false -> None

let parseMethod (line: string, schema: Schema) =
    let matches = Regex.Matches(line, "^([a-zA-Z\.\_]*)#([0-9a-z]*) (.*) = (.*);$")
    

let Parse (schema:string[]) =

    for line in schema do
        match isCommented line with
        | Some(_) -> ()
        | None -> 

    ()