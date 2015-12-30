// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
//open Operators
open System
type osoba = {imie : string; nazwisko : string; indeks : int}
let kazek = {imie = "Kazimierz"; nazwisko = "Nowak"; indeks = 124567}
let janek = {imie = "Jan"; nazwisko = "Nowak"; indeks = 124557}
let franek = {imie = "Franciszek"; nazwisko = "Kielar"; indeks = 124566}
let studenci = [kazek;janek;franek]
let x = List.length studenci
let sprawdz :bool =
    let mutable y = 0
    for i = 0 to x-1 do
        for k = 0 to x-1 do
            if (studenci.[i].nazwisko = studenci.[k].nazwisko) then y <- y+1
                //elif y>1 then true
    if y > x then true
    else false
[<EntryPoint>]
let main argv =
    let x = sprawdz
    printfn "%A" x 
    0  // return an integer exit code