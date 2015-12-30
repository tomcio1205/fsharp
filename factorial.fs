// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
//open Operators
open System
exception UJEMNY_ARGUMENT
let rec silnia n =
    if (n < 2 && n > 0) then 1
    elif n < 0 then raise(UJEMNY_ARGUMENT)
    else n*silnia (n-1)
[<EntryPoint>]
let main argv =
    let x = silnia (-4)
    printfn "%A" x
    0 // return an integer exit code