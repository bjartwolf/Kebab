module Trees.Test
open Trees
open FsCheck.Xunit
open Xunit

[<Property>]
let ``Doubleflipped trees are equal to themselves`` (t: tree) =
    flip (flip t) = t

//[<Fact>]
//let ``Flipped unsymmetric tree is different from self`` () =
//    let tree = LeftFruit(Some Pear, Bud)
//    flip tree |> should not' (equal tree)


[<Fact>]
let ``Flipped bud is equal to self`` () =
    flip Bud = Bud

[<Property(Verbose=true)>]
let ``Eating pears does not change a tree if it doesn't have pears`` (t: tree) =
    if (hasPear t) then not (eatPear t = t) else eatPear t = t

[<Property(Verbose=true)>]
let ``Flipped unsymmetric tree is not equal to self`` (f: fruit) =
    let t = LeftFruit (Some f, Bud)
    not (t = flip t)