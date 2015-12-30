// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System
exception DzieleniePrzezZero
let rec NWD(m, n) =
    if n = 0 then abs m
    else NWD (n, (m%n))
let skroc (l,m) =
let znak = if l*m<0 then -1 else 1
    let al = abs l
    let am = abs m
    let d = NWD(al,am)
    in (znak * (al / d), am / d)
[<EntryPoint>]
let main argv =
    let x = skroc(7,21)
    printfn "%A" x
    0 // return an integer exit code