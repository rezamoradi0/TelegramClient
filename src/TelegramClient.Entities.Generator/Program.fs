module Program

open System
open System.IO

open Models
open TlProcessor

[<EntryPoint>]
let main argv = 
    File.ReadLines("scheme.tl")
    |> Parse 

    Console.ReadLine() |> ignore
    0
        