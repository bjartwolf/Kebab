open System
open Microsoft.Owin.Hosting

[<EntryPoint>]
let main argv = 

    let baseAddress = "http://*:50000"

    use application = WebApp.Start<Startup.Startup>(baseAddress)

    Console.WriteLine("Server running on {0}", baseAddress)
    Console.WriteLine("hit <enter> to stop")
    Console.ReadLine() |> ignore
    0 // return an integer exit code
