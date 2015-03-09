module TestKebab

open NUnit.Framework
open FsCheck
open System 
open FsCheck.NUnit
open Kebab

//[<Property>]
//let ``A bottom is always a  rod or plate`` (bottom: Bottom) =
//    let kebab = Onion(Tomato (Onion(Bottom bottom)))
//    let bottom = WhatBottom kebab 
//    bottom = Rod || bottom = Plate 

[<Property>]
let ``A shish of bottoms bottom is always a  rod or plate`` (kebab: shish<Bottom>) =
    let bottom = WhatBottom kebab 
    bottom = Rod || bottom = Plate 

[<Property>]
let ``A shish should never have Onions on top of Lamb`` (kebab: shish<Bottom>) =
    let cleanBab = getRidOfOnions kebab
    let rec hasOnionsOnLamb kebab = match kebab with
        | Bottom _ -> false 
        | Onion (Lamb (x)) -> true 
        | Onion (x) -> hasOnionsOnLamb x 
        | Lamb (x) -> hasOnionsOnLamb x 
        | Tomato (x) -> hasOnionsOnLamb x 
    not (hasOnionsOnLamb cleanBab)