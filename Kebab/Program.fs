// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
module kebabapp
open Kebab
open System 

[<EntryPoint>]
let main argv = 
    let aBab = Onion(Tomato (Onion(Bottom GoldPlate)))
    let anotherBab = Onion(Lamb(Onion(Tomato(Bottom 53))))
    Console.WriteLine (sprintf "%A" aBab)
    Console.ReadLine() |> ignore
    0 // return an integer exit code
