string input = System.IO.File.ReadAllText("../Inputs/2021_02.txt");

string[] lines = input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
int forward1 = 0, depth1 = 0;

foreach (string item in lines) {
    string[] instructions = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    int value = int.Parse(instructions[1]);
    if (instructions[0] == "forward") {
        forward1 += value;
    }
    else if (instructions[0] == "up") {
        depth1 -= value;
    }
    else if (instructions[0] == "down") {
        depth1 += value;
    }
}
int result1 = forward1 * depth1;
System.Console.WriteLine(result1);

int forward2 = 0, aim = 0, depth2 = 0;

foreach (string item in lines) {
    string[] instructions = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    int value = int.Parse(instructions[1]);
    if (instructions[0] == "forward") {
        forward2 += value;
        depth2 += value * aim;
    }
    else if (instructions[0] == "up") {
        aim -= value;
    }
    else if (instructions[0] == "down") {
        aim += value;
    }
}

int result2 = forward2 * depth2;
System.Console.WriteLine(result2);
