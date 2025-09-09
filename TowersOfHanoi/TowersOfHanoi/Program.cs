int n;
Console.WriteLine("Welcome to Towers of Hanoi");
Console.WriteLine("Enter an n value(num of disks): ");
while (!int.TryParse(Console.ReadLine(), out n) && n <= 0) {
    Console.WriteLine("Enter a valid number: ");
}
int movesRequired = TowersOfHanoi(n);

Console.WriteLine("Number of moves required: " + movesRequired);
static int TowersOfHanoi(int n) {
    List<int> Apeg = new List<int>();
    List<int> Bpeg = new List<int>();
    List<int> Cpeg = new List<int>();
    int moves = 0;
    bool solved = false;
    for(int i = n; i > 0; i--) { //initialize first peg with n disks
        Apeg.Add(i);
    }
    while (!solved) {

        if (n == 1) {
            int elementToMove = Apeg[Apeg.Count - 1];
            Apeg.Remove(elementToMove);
            Cpeg.Add(elementToMove);
            moves++;
        } else { // n > 1
            if (Cpeg.Count != n) { //Solution not solved

            }
            if (Apeg.Count != 0) {
                int elementToMove = Apeg[Apeg.Count - 1];//grab last one from Apeg
            }
            
        }








        if (Cpeg.Count == n) {
            solved = true;
        }

        
    }
    return moves;
}
