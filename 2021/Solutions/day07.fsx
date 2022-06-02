open System.IO
open System

let input = File.ReadAllLines("../Inputs/2021_07.txt") |> Array.head

let crap_positions = input.Split(',') |> Seq.map int64 |> Seq.toList

let get_fuel_consumption distance_transformation target_pos = 
    let fuels_cost pos = (pos - target_pos) |> abs |> distance_transformation
    crap_positions |> List.map fuels_cost |> List.sum

let max_pos = crap_positions |> List.max
let min_pos = crap_positions |> List.min
let target_positions = [min_pos .. max_pos]

let x = target_positions |> List.map (fun p -> p, (get_fuel_consumption (fun z -> z * z)) p)

let solve distance_transformation = 
    target_positions 
        |> List.map (get_fuel_consumption distance_transformation) 
        |> List.min

printfn "Part1: %i" (solve (fun x -> x))
printfn "Part2: %i" (solve (fun n -> [1L..n] |> List.sum))