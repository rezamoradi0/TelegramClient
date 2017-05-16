module Models

open System;

type Param = {Name: string; Type: string}

type Method = {Id: int; Method: string; Params: Param seq; Type: string }

type Constructor = {Id: int; Predicate: string; Params: Param seq; Type: string }

type Schema = {Constructors: Constructor seq; Methods: Method seq;}