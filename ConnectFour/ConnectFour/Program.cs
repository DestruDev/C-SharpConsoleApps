

Console.WriteLine("Welcome to Connect Four.");
int[,] connectSheet = new int[6, 7];
    for (int i = 0; i < 6; i++) {
        for (int j = 0; j < 7; j++) {
            connectSheet[i, j] = 0; // Empty default
        }
    }

PrintMatrix(connectSheet);
PrintInfo();
Random rand = new Random();
int coinFlip = rand.Next(1, 3);
bool turnOrder = false;
if (coinFlip == 1) {
    Console.WriteLine("1st player goes first.");
    turnOrder = true; // 1st player = true 2nd player = false
} else {
    Console.WriteLine("Second player goes first.");
}
bool gameEnded = false;
int choice;

while (!gameEnded) {
    if (turnOrder) { // Who's turn is it?
        Console.WriteLine("1st player, Enter a column: ");
    } else {
        Console.WriteLine("2nd player, Enter a column: ");
    }
    
    string input = Console.ReadLine();
    if (int.TryParse(input, out choice)) {
        if (choice >= 0 && choice <= 6) {
            int startingRow = 5;
            if (turnOrder) {
                
                while (startingRow >= 0) {
                    if (connectSheet[startingRow, choice] == 0) { //empty
                        connectSheet[startingRow, choice] = 1; //occupy
                        break;
                    } else {
                        startingRow -= 1;
                        if(startingRow < 0) {
                            Console.WriteLine("ERROR: Full column.");
                            turnOrder = !turnOrder;
                        }
                    }
            
                }
                
            } else {
                while (startingRow >= 0) {
                    if (connectSheet[startingRow, choice] == 0) { //empty
                        connectSheet[startingRow, choice] = 2;
                        break;
                    } else {
                        startingRow -= 1;
                        if (startingRow < 0) {
                            Console.WriteLine("ERROR: Full column.");
                            turnOrder = !turnOrder; //prevents turn switch
                        }
                    }

                }
            }
            
            PrintMatrix(connectSheet);
            PrintInfo();
            turnOrder = !turnOrder;
        } else {
            Console.WriteLine("Choose a valid column. ");
            PrintInfo();
        }
    } else {
        Console.WriteLine("Enter a valid digit.");
        PrintInfo();
    }

    if (CheckForWinner(connectSheet) == 1) {
        gameEnded = true;
        Console.WriteLine("Player 1 has won!");

    } else if (CheckForWinner(connectSheet) == 2) {
        gameEnded = true;
        Console.WriteLine("Player 2 has won!");
    } else {
        gameEnded = false;
    }

}

static void PrintInfo() {
    string columnLabels = "0 1 2 3 4 5 6";
    Console.WriteLine("----------------------");
    Console.WriteLine(columnLabels);
}

static void PrintMatrix(int[,] matrix) {
    for (int i = 0; i < 6; i++) {
        for (int j = 0; j < 7; j++) {
            Console.Write(matrix[i, j] + " "); // Print character with space
        }
        Console.WriteLine(); // Move to the next row
    }
}

static int CheckForWinner(int[,] matrix) { //online algorithm
    // Check horizontally
    for (int i = 0; i < 6; i++) {
        for (int j = 0; j <= 3; j++) {
            if (matrix[i, j] != 0 &&
                matrix[i, j] == matrix[i, j + 1] &&
                matrix[i, j] == matrix[i, j + 2] &&
                matrix[i, j] == matrix[i, j + 3]) {
                return matrix[i, j]; // Return the winning player (1 or 2)
            }
        }
    }

    // Check vertically
    for (int i = 0; i <= 2; i++) {
        for (int j = 0; j < 7; j++) {
            if (matrix[i, j] != 0 &&
                matrix[i, j] == matrix[i + 1, j] &&
                matrix[i, j] == matrix[i + 2, j] &&
                matrix[i, j] == matrix[i + 3, j]) {
                return matrix[i, j]; // Return the winning player (1 or 2)
            }
        }
    }

    // Check diagonally (top-left to bottom-right)
    for (int i = 0; i <= 2; i++) {
        for (int j = 0; j <= 3; j++) {
            if (matrix[i, j] != 0 &&
                matrix[i, j] == matrix[i + 1, j + 1] &&
                matrix[i, j] == matrix[i + 2, j + 2] &&
                matrix[i, j] == matrix[i + 3, j + 3]) {
                return matrix[i, j]; // Return the winning player (1 or 2)
            }
        }
    }

    // Check diagonally (top-right to bottom-left)
    for (int i = 0; i <= 2; i++) {
        for (int j = 3; j < 7; j++) {
            if (matrix[i, j] != 0 &&
                matrix[i, j] == matrix[i + 1, j - 1] &&
                matrix[i, j] == matrix[i + 2, j - 2] &&
                matrix[i, j] == matrix[i + 3, j - 3]) {
                return matrix[i, j]; // Return the winning player (1 or 2)
            }
        }
    }

    return 0; // No winner
}




