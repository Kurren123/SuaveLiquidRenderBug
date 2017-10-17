type M1 =
    { name : string }

let subject =
    Suave.DotLiquid.renderPageString "Hi {{ model.name }}" { M1.name = "haf3" }
    |> Async.RunSynchronously

[<EntryPoint>]
let main argv = 
    printfn "%A" subject
    System.Console.ReadLine() |> ignore
    0