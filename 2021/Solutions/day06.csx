using System;
using System.Collections.Generic;
string[] input = System.IO.File.ReadAllText("../Inputs/2021_06.txt").Split(',');
int[] int_input = Array.ConvertAll(input, int.Parse);
int[] int_input_copy = new int[int_input.Length];
Array.Copy(int_input, int_input_copy, int_input.Length);
// PART 1
int totalDays = 80;
for (int day = 0; day < totalDays; day++) {
    int index = 0;
    var newBirths = new List<int>();
    foreach (int fish in int_input) {

        if (fish == 0) {
            int_input[index] = 6;
            newBirths.Add(8);
        }
        else {
            int_input[index] = fish - 1;
        }

        index++;    
    }
    int_input = int_input.Concat( newBirths.ToArray() ).ToArray();
}

System.Console.WriteLine(int_input.Length);

//PART 2
totalDays = 256;

long[] fishGeneration = new long[9];
foreach (int i in int_input_copy) 
    fishGeneration[i]++;
System.Console.WriteLine(fishGeneration[2]);

for (int day = 0; day < totalDays; day++) {
    long newOnes = fishGeneration[0];
    for (int i = 1; i < fishGeneration.Length; i++) {
        fishGeneration[i - 1] = fishGeneration[i];
    }

    fishGeneration[8] = newOnes;
    fishGeneration[6] += newOnes;
}
System.Console.WriteLine(fishGeneration.Sum());