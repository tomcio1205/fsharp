// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System
let rec NWD(m, n) =
    if n = 0 then abs m
    else NWD (n, (m%n))
[<EntryPoint>]
let main argv =
    let x = NWD(600,400)
    printfn "%A" x
    0 // return an integer exit code