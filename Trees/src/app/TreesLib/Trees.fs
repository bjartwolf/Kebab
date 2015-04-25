module Trees

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

let flip tree = tree
//let rec flip tree =
 //   match tree with
 //      | Bud -> Bud
 //      | RightFruit(t, f) -> LeftFruit(f, flip(t))
 //      | LeftFruit(f, t) -> RightFruit(t, f)
 //      | Split (t1, t2) -> Split (flip(t2), flip(t1))

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