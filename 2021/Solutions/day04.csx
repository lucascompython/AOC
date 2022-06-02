/* TODO END THIS SHIT*/


string input = System.IO.File.ReadAllText("../Inputs/2021_04.txt");
//string teste = String.Join("|", input);
//string [] boards = teste.Split('|');
//System.Console.WriteLine(boards[2]);
//foreach(var item in input.Skip(1)) {
    //System.Console.WriteLine(item);
//}
var morre = BoardBuilder(input);
int index = 0;
//foreach(var item in morre) {
    //if(index == 5) {
        //System.Console.WriteLine("\n--------\n");
        //index = 0;
    //}
    //foreach(var item2 in item) {
    
        //System.Console.WriteLine(item2);
        //index++;
    //}
//}



List<List<string>> BoardBuilder (string input) {
    string[] lines = input.Split(new string[] { "\n", "\r", "\r\n", "\n\r" }, StringSplitOptions.RemoveEmptyEntries);
    int index = 0;
    var boards = new List<List<string>>();
    var tempBoard = new List<string>();
    foreach (string line in lines.Skip(1)) {

        
        if (index == 5) {
            index = 0;
            boards.Add(tempBoard);
            //System.Console.WriteLine("\n-----------\n");
            //foreach (var item in tempBoard)
            //{
                //System.Console.WriteLine(item);   
            //}
            tempBoard.Clear();
        }
        tempBoard.Add(line);
        //System.Console.WriteLine($"Line: {line} -> Index: {index}");
        index++;
    }
    boards.ForEach(board => board.ForEach(line => System.Console.WriteLine(line)));
    return boards;
}