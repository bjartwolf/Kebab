// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open Trees
open System 
[<EntryPoint>]
let main argv = 
    let tree = flip(Split (Bud, LeftFruit(Some Fig, Bud)))
    printfn "%A" tree 
    Console.ReadLine() |> ignore
    0 // return an integer exit code