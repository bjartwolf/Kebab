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

type fruit = 
    Fig
  | Orange
  | Peach
  | Apple
  | Pear

type tree = 
    Bud
  | LeftFruit of fruit option * tree
  | RightFruit of tree * fruit option 
  | Split of tree * tree

let rec flip tree =
    match tree with
       | Bud -> Bud
       | RightFruit(t, f) -> LeftFruit(f, flip(t))
       | LeftFruit(f, t) -> RightFruit(flip(t), f)
       | Split (t1, t2) -> Split (flip(t2), flip(t1))

let rec hasPear tree = 
    match tree with
       | Bud -> false 
       | RightFruit(t, f) -> match f with 
                                | Some (Pear) -> true 
                                | _ -> hasPear t
       | LeftFruit(f, t) -> match f with 
                                | Some (Pear) -> true 
                                | _ -> hasPear t
       | Split (t1, t2) -> hasPear t1 ||  hasPear t2

let rec eatPear tree =
    match tree with
       | Bud -> Bud
       | RightFruit(t, f) -> match f with 
                                | Some (Pear) -> RightFruit (eatPear t, None)
                                | f -> RightFruit (eatPear t, f)
       | LeftFruit(f, t) -> match f with 
                                | Some (Pear) -> LeftFruit (None, eatPear t)
                                | f -> LeftFruit (f, eatPear t)
       | Split (t1, t2) -> Split (eatPear t1, eatPear t2)