// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System
let liczWyst (d:string,n:char):int=
let len = String.length d
    let ilosc = ref 0
    for i = 0 to len - 1 do
        if (d.[i]= n) then incr(ilosc)
    ilosc.Value
[<EntryPoint>]
let main argv =
    let x = liczWyst("Ala ma kota, psa i koguta",'t') printfn "%A" x
    0 // return an integer exit code