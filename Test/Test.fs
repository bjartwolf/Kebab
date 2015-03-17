module TestKebab

open Xunit
open FsCheck
open System 
open FsCheck.Xunit
open Kebab

//[<Property>]
//let ``A bottom is always a  rod or plate`` (bottom: Bottom) =
//    let kebab = Onion(Tomato (Onion(Bottom bottom)))
//    let bottom = WhatBottom kebab 
//    bottom = Rod || bottom = Plate 

[<Property>]
let ``A shish is always vegetarian`` (kebab: shish<Bottom>) =
    isVeg kebab 
 
[<Property>]
let ``A shish is always served on expensive plates`` (kebab: shish<Bottom>) =
    (getValueOfBottom (WhatBottom kebab)) < 50



[<Property>]
let ``A shish should never have Onions on top of Lamb`` (kebab: shish<Bottom>) =
    let cleanBab = getRidOfOnions kebab
    let rec hasOnionsOnLamb kebab =
        match kebab with
            | Bottom _ -> false 
            | Onion (Lamb (x)) -> true 
            | Onion (x) -> hasOnionsOnLamb x 
            | Lamb (x) -> hasOnionsOnLamb x 
            | Tomato (x) -> hasOnionsOnLamb x
            | Corn x -> hasOnionsOnLamb x
    not (hasOnionsOnLamb cleanBab)

