module Trees.Test
open Trees
open FsCheck.Xunit

[<Property>]
let ``Doubleflipped trees are equal to themselves`` (t: tree) =
    flip (flip t) = t

[<Property(Verbose=true)>]
let ``Eating pears does not change a tree if it doesn't have pears`` (t: tree) =
    if (hasPear t) then not (eatPear t = t) else eatPear t = t