// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello It's me Bibek!#"
let rec factorial b acc =
    if b = 0 then
        acc
    else
        factorial (b - 1) (acc * b)

let result = factorial 4 2
printfn "Factorial of 4 is: %d" result

