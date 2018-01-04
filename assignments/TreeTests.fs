module TreeTests

open Trees

let revRevIsOrig (xs:list<int>) = List.rev(List.rev xs) = xs


let ``Doubleflipped trees are equal to themselves`` (t: tree) =
    flip (flip t) = t

let ``Flipped unsymmetric tree is different from self`` =
    let tree = LeftFruit(Some Pear, Bud)
    not(flip tree = tree)

let ``Flipped bud is equal to self`` = fun () ->
    flip Bud = Bud

let ``Eating pears does not change a tree if it doesn't have pears`` = fun (t: tree) ->
    if (hasPear t) then not (eatPear t = t) else eatPear t = t

let ``Flipped unsymmetric tree is not equal to self`` = fun (f: fruit) ->
    let t = LeftFruit (Some f, Bud)
    not (t = flip t)