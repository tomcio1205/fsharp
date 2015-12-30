// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
//open Operators
open System
exception UJEMNY_ARGUMENT
let rec potega(a, b) =
    if b = 0 then 1
    elif b < 0 then raise(UJEMNY_ARGUMENT)
    else a*potega(a,b-1)
[<EntryPoint>]
let main argv =
    let x = potega (4,4)
    printfn "%A" x
    0 // return an integer exit code