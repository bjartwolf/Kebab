module Trees.Test
open Trees
open FsCheck.Xunit
open Xunit
open FsUnit.Xunit

[<Property>]
let ``Doubleflipped trees are equal to themselves`` (t: tree) =
    flip (flip t) = t

[<Fact>]
let ``Flipped bud is equal to self`` () =
    flip Bud = Bud

[<Fact>]
let ``Flipped unsymmetric tree is different from self`` () =
    let tree = LeftFruit(Some Pear, Bud)
    flip tree |> should not' (equal tree)

[<Property(Verbose=true)>]
let ``Eating pears does not change a tree if it doesn't have pears`` (t: tree) =
    if (hasPear t) then not (eatPear t = t) else eatPear t = t