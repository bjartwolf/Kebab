module Kebab

type Rod = Dagger | Sword | Fork
type Plate = GoldPlate | SilverPlate | BronzePlate
type Bottom = Rod | Plate
type shish<'A> =
    Bottom of 'A 
    | Onion of shish<'A>
    | Lamb of shish<'A>
    | Tomato of shish<'A>
let rec getRidOfOnions kebab =
    match kebab with 
        | Bottom (x) -> Bottom (x)
        | Onion (x) -> Onion(getRidOfOnions x)
        | Lamb (x) -> Lamb (getRidOfOnions x)
        | Tomato (x) -> Tomato (getRidOfOnions x)

let rec isVeg kebab =
    match kebab with
        | Bottom (x) -> true
        | Onion (x) ->  isVeg x
        | Lamb (x) -> false
        | Tomato (x) -> isVeg x
let rec WhatBottom kebab =
     match kebab with
        | Bottom (x) -> x
        | Onion (x) -> WhatBottom x
        | Lamb (x) -> WhatBottom x
        | Tomato (x) -> WhatBottom x
