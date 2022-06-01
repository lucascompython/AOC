open System


let input = 
    IO.File.ReadAllLines("../Inputs/2021_03.txt")
    |> List.ofArray

let getCharList (s: string) =
    s.ToCharArray() |> List.ofSeq

let convertStringToDecimal s =
    Convert.ToInt32(s, 2)

let convertCharsToDecimal (chars: char list) =
    chars
    |> Array.ofList 
    |> String
    |> convertStringToDecimal

let mostCommonChar charList =
    let char, count =
        charList
        |> List.countBy id
        |> List.maxBy (fun (char, count) -> count)
    char

let leastCommonChar charList =
    let char, count =
        charList
        |> List.countBy id
        |> List.minBy (fun (char, count) -> count)
    char

let findInstruction (criteria: char list -> char) (instructions: string list) =
    instructions
    |> List.map getCharList
    |> List.transpose
    |> List.map criteria
    |> convertCharsToDecimal

let gammaRate = 
    input |> findInstruction mostCommonChar

let epsilonRate = 
    input |> findInstruction leastCommonChar

let result1 = gammaRate * epsilonRate
printfn "Result1: %d" result1