// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
//open Operators
open System
exception DzieleniePrzezZero
[<EntryPoint>]
let main argv =
    let ( ++ ) (a, b) (c, d) :string=
         let znak = if b+d<0 then "" else " + "  
         string(a + c) + znak + string(b + d) + "i";
    let ( -- ) (a, b) (c, d) :string=    
         let znak = if b-d<0 then "" else " + "  
         string(a - c) + znak + string(b - d) + "i";
    let ( ** ) (a, b) (c, d) :string= 
         let znak = if a*d+b*c<0 then "" else " + "  
         string(a*c-b*d)+znak+string(a*d+b*c)+"i"
    let ( /./ ) (a, b) (c, d) = 
         if c*c+d*d=0 then raise DzieleniePrzezZero
         let znak = if b*c-a*d<0 then "" else " + "
         "("+string(a*c+b*d)+znak+string(b*c-a*d)+"i"+")"+"/"+string(c*c+d*d)  
    let x = ( /./ )(2,3)(3,4)
    printfn "%A" x
    0 // return an integer exit code 