// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
//open Operators
open System
let mnozenie (a,b,c) =
    let z = a * c
    let znak = if a<0 then -1 else 1 
    in (znak*z,b)

let dzielenie (a,b,c) =
    let z = b * c
    let znak = if a<0 then -1 else 1
    in (znak*a,z)
let pierwiastek (a,b) =
    let znak = if a<0 then -1.0 else 1.0
    let x = sqrt (float(a))
    let y = sqrt (float(b))
    in (znak * x, y)
let odwrotnosc(a, b) =
    let z = a
    let y = b
    in (y,z)
    
[<EntryPoint>]
let main argv =
    let x = mnozenie(2,3,4)
    let y = dzielenie(4,5,6)
    let z = pierwiastek(4,8)
    let j = odwrotnosc(4,5)
    printfn "%A" x
    printfn "%A" y
    printfn "%A" z
    printfn "%A" j
    0 // return an integer exit code