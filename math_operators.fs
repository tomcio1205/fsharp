// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System
exception DzieleniePrzezZero
[<EntryPoint>]
let main argv =
    let ( ++ ) (a, b) (c, d) =
         if b = 0 || d = 0 then raise DzieleniePrzezZero
         else (a*d + b*c, b*d);
    let ( -- ) (a, b) (c, d) =
         if b = 0 || d = 0 then raise DzieleniePrzezZero
         else (a*d - b*c, b*d);
    let ( ** ) (a, b) (c, d) =
         if b = 0 || d = 0 then raise DzieleniePrzezZero
         else (a*c, b*d);
    let ( /./ ) (a, b) (c, d) =
         if b = 0 || d = 0 then raise DzieleniePrzezZero
         else (a,b) ** (d,c);
    let x = (--)(2,3)(3,4)
    printfn "%A" x
    0 // return an integer exit code