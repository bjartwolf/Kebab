module Kebab

type rod = Dagger  | Sword  | Fork 
type plate = GoldPlate of int | SilverPlate  | BronzePlate 
type Bottom = Rod of rod | Plate of plate
type shish<'α> =
    Bottom of 'α 
    | Onion of shish<'α>
    | Lamb of shish<'α>
    | Tomato of shish<'α>
    | Corn of shish<'α>

let getValueOfBottom bottom = 
    match bottom with 
        | Plate (GoldPlate x) -> x
        | _ -> 0

let rec getRidOfOnions kebab =
    match kebab with 
        | Bottom x -> Bottom x
        | Onion x -> getRidOfOnions x
        | Corn x -> Corn (getRidOfOnions x)
        | Lamb x -> Lamb (getRidOfOnions x)
        | Tomato x -> Tomato (getRidOfOnions x)

let (|Vegetable|Meat|Hardware|) input = 
        match input with 
                | Onion x -> Vegetable x
                | Corn x -> Vegetable x
                | Lamb x-> Meat x
                | Bottom x-> Hardware x
                | Tomato x-> Vegetable x

let rec isVeg kebab =
    match kebab with
        | Hardware (x) -> true
        | Vegetable (x) ->  isVeg x
        | Meat (x) -> false

let rec WhatBottom kebab =
     match kebab with
        | Bottom x -> x
        | Onion x -> WhatBottom x
        | Lamb x -> WhatBottom x
        | Tomato x -> WhatBottom x
        | Corn x -> WhatBottom x

