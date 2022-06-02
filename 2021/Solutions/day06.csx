string[] input = System.IO.File.ReadAllText("../Inputs/2021_06.txt").Split(',');
int[] int_input = Array.ConvertAll(input, int.Parse);



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