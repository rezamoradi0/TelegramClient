module Models

open System;

type TlParam = {Name: string; Type: string}

type TlMethod = {Id: int; Method: string; Params: TlParam list; Type: string }

type TlType = {Id: int; Predicate: string; Params: TlParam list; Type: string }

type Schema = {Types: TlType list; Methods: TlMethod list;}