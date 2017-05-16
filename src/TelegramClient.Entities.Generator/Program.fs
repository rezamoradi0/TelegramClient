module Program

open System
open System.IO;

[<EntryPoint>]
let main argv = 
    let scheme = File.ReadLines("scheme.tl")
    0
        