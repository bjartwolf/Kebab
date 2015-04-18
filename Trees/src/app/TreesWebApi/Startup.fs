module Startup

    open Owin
    open Microsoft.Owin
    open System
    open System.IO
    open System.Threading.Tasks
    open Trees

    type public Startup() = 
        let t1 = LeftFruit (Some Fig, Bud)
        let handleOwinContext (context:IOwinContext) =

            use writer = new StreamWriter(context.Response.Body)

            match context.Request.Method with
            | "GET" -> 
                use reader = new StreamReader(context.Request.Body)
                let rec printtree tree = match tree with
                                        | Bud -> "Grein"
                                        | LeftFruit (f, t) -> "Frukt" +  printtree t
                                        | RightFruit (t,f) -> "Frukt" +  printtree t
                                        | Split (t1, t2) ->  printtree t1 + printtree t2
                writer.Write(printtree t1)
            | _ ->
                context.Response.StatusCode <- 400
                writer.Write("Only GET")

        let owinHandler = fun (context:IOwinContext) (_:Func<Task>) -> 
            handleOwinContext context; 
            Task.FromResult(null) :> Task

        member x.Configuration (app:IAppBuilder) = app.Use(owinHandler) |> ignore