#I @"..\packages\FsCheck\lib\net452"
#r "FsCheck.dll"

open FsCheck

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

let revRevIsOrig (xs:list<int>) = List.rev(List.rev xs) = xs


let ``Doubleflipped trees are equal to themselves`` (t: tree) =
    flip (flip t) = t

let ``Flipped unsymmetric tree is different from self`` () =
    let tree = LeftFruit(Some Pear, Bud)
    not(flip tree = tree)


let ``Flipped bud is equal to self`` () =
    flip Bud = Bud

let ``Eating pears does not change a tree if it doesn't have pears`` (t: tree) =
    if (hasPear t) then not (eatPear t = t) else eatPear t = t

let ``Flipped unsymmetric tree is not equal to self`` (f: fruit) =
    let t = LeftFruit (Some f, Bud)
    not (t = flip t)


Check.Quick  ``Flipped unsymmetric tree is not equal to self``
Check.Quick ``Eating pears does not change a tree if it doesn't have pears``