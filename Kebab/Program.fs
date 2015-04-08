// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
module kebabapp
open Kebab
open System 
open FsCheck

let bar (kebab: shish<Bottom>) =
    let cleanBab = getRidOfOnions kebab
    let rec hasOnionsOnLamb kebab =
        match kebab with
            | Bottom _ -> false 
            | Onion (Lamb (x)) -> true 
            | Onion (x) -> hasOnionsOnLamb x 
            | Lamb (x) -> hasOnionsOnLamb x 
            | Tomato (x) -> hasOnionsOnLamb x 
            | Corn (x) -> hasOnionsOnLamb x
    not (hasOnionsOnLamb cleanBab)

let foo = FsCheck.Check.Quick bar

[<EntryPoint>]
let main argv = 
    let aBab = Onion(Tomato (Onion(Bottom GoldPlate)))
    let anotherBab = Onion(Lamb(Onion(Tomato(Bottom 53))))
    let tree = flip(Split (Bud, LeftFruit(Some Fig, Bud)))
    Console.WriteLine (sprintf "%A" foo)
    Console.WriteLine (sprintf "%A" aBab)
    Console.WriteLine (sprintf "%A" tree)
    Console.ReadLine() |> ignore
    0 // return an integer exit code
