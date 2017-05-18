module Models

open System;
open System.Collections.Generic;

type TlParam = {Name: string; Type: string}

type TlMethod = {Id: string; Method: string; Params: TlParam list; Type: string }

type TlType = {Id: string; Predicate: string; Params: TlParam list; Type: string }

type Schema = {Types: List<TlType>; Methods: List<TlMethod>}