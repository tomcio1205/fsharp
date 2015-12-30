// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
//open Operators
open System
let rec pierwsza'(n,k) :bool=
    if k = 1 then true
    elif n = 1 then false
    elif n%k=0 then false
    else pierwsza'(n,k-1)
let pierwsza n = 
    pierwsza'(n,n-1)
    
[<EntryPoint>]
let main argv =
    let x = pierwsza(17)
    printfn "%A" x
    0 // return an integer exit code