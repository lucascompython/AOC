let input:seq<int> = System.IO.File.ReadAllLines("../Inputs/2021_01.txt") |> Seq.map int

let isIncrease (a: int, b: int): bool =
    b > a

let result1: int = 
    input 
    |> Seq.pairwise
    |> Seq.filter isIncrease
    |> Seq.length

printf ("Result 1: %d\n") result1



let result2: int =
    input
    |> Seq.windowed 3
    |> Seq.map (Seq.sum)
    |> Seq.pairwise
    |> Seq.filter isIncrease
    |> Seq.length

printf ("Result 2: %d\n") result2