using System.Numerics;

Console.WriteLine("Welcome to Tic-Tac-Toe!");
char[,] board = new char[3, 3];
for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
        board[i, j] = ' '; // Empty default
    }
}
Random rand = new Random();
int coinFlip = rand.Next(0, 2);
bool turnOrder = false; ;
if (coinFlip == 1) {
    Console.WriteLine("1st player goes first.");
    turnOrder = true; // 1st player = true 2nd player = false
} else {
    Console.WriteLine("2nd player goes first.");
}

bool gameEnded = false;
int choiceX;
int choiceY;

while (!gameEnded) {

    PrintMatrix(board);
    if (turnOrder) { // Who's turn is it?
        Console.WriteLine("1st player, Enter X value: ");
    } else {
        Console.WriteLine("2nd player, Enter X value: ");
    }
    while (true) { //Loop for valid X
        Console.WriteLine("Choose X position on the board:");
        string input1 = Console.ReadLine();
        if (int.TryParse(input1, out choiceX) && choiceX >= 0 && choiceX <= 2) {
            break;
        } else {
            Console.WriteLine("Enter a valid X value: ");
        }
    }

    while (true) { //Loop for valid X
        Console.WriteLine("Choose Y position on the board:");
        string input2 = Console.ReadLine();
        if (int.TryParse(input2, out choiceY) && choiceY >= 0 && choiceY <= 2) {
            break;
        } else {
            Console.WriteLine("Enter a valid Y value: ");
        }
    }


    if (turnOrder) {//1st player turn
        if (board[choiceY, choiceX] == ' ') {
            board[choiceY, choiceX] = 'X';
            turnOrder = !turnOrder; //switch turns
        } else {
            Console.WriteLine("Invalid position.");
        }
    } else {
        if (board[choiceY, choiceX] == ' ') {
            board[choiceY, choiceX] = 'O';
            turnOrder = !turnOrder; //switch turns
        } else {
            Console.WriteLine("Invalid position.");
        }

    }
    if(CheckWin(board) == 1) {
        if (turnOrder) {
            Console.WriteLine("1st player wins!");
        } else {
            Console.WriteLine("2nd player wins!");
        }
        gameEnded = true;
    } else if (CheckWin(board) == 2) {
        Console.WriteLine("Draw");
        gameEnded = true;
    }
    
}
static int CheckWin(char[,] board) {
    // Check rows and columns
    for (int i = 0; i < 3; i++) {
        if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2]) return 1;
        if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[1, i] == board[2, i]) return 1;
    }
    // Check diagonals
    if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) return 1;
    if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]) return 1;

    
    bool isFull = true;    
    foreach (char cell in board) {
        if (cell == ' ') {
            isFull = false;
            break;
        }
    }
    if (isFull) {
        return 2;
    }
    return 0;
}

static void PrintMatrix(char[,] matrix) {
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine(count);
        count++;
    }
    Console.WriteLine("0 1 2");
}

static bool BoardFull(char[,] matrix) {
    bool IsDraw = false;
    foreach (char cell in matrix) {
        if (cell == ' ')
        {
            IsDraw =  false;
        }
    }
    return true ;
}