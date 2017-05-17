module Models

open System;
open System.Collections.Generic;

type TlParam = {Name: string; Type: string}

type TlMethod = {Id: int; Method: string; Params: TlParam list; Type: string }

type TlType = {Id: int; Predicate: string; Params: TlParam list; Type: string }

type Schema = {Types: List<TlType>; Methods: List<TlMethod>}