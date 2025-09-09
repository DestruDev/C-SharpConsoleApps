
using System;

Console.WriteLine("Welcome to Tetris");
char[,] tetrisField = new char[30, 10];
for (int i = 0; i < 30; i++) {
    for (int j = 0; j < 10; j++) {
        tetrisField[i, j] = ' '; // Empty default
    }
}


int dropY = 0;
int dropX = 0;
int speedCounter = 0;

Thread thread1 = new Thread(() => PlayerControls(ref dropX));
Thread thread2 = new Thread(() => GravityLoop(tetrisField, ref dropY, ref speedCounter));

thread1.Start();
thread2.Start();
static void PlayerControls(ref int dropX) {

    while (true) {
        char playerInput = Console.ReadKey(intercept: true).KeyChar; // intercept to avoid input showing up
        if (playerInput == 'a') {
            dropX--;
        } else if (playerInput == 'd') {
            dropX++;
        }
    }
    
    
}


static void GravityLoop(char[,] matrix, ref int dropY, ref int speedCounter) {
    while (dropY < 30) {
        Console.Clear(); // Clears console for smooth animation

        // Clear the previous 'O' position (if it's not the first row)
        if (dropY > 0) {
            matrix[dropY - 1, 4] = ' ';
        }

        // Set 'O' in the new position
        matrix[dropY, 4] = 'O';

        PrintMatrix(matrix);

        /*
        if (speedCounter > 60) { //speed levels based on time program has run
            Thread.Sleep(250);
        } else if (speedCounter > 30) {
            Thread.Sleep(500);
        } else if (speedCounter > 10) {
            Thread.Sleep(1000);
        } else if (speedCounter >= 5) {
            Thread.Sleep(2000);
        } else {
            Thread.Sleep(2500);
        }
        */

        Thread.Sleep(500);
        speedCounter++;
        dropY++; // Move to the next row
    }

}

static void PrintMatrix(char[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            Console.Write(matrix[i, j]); // Print character with space
        }
        Console.WriteLine(); // Move to the next row
    }

    for (int i = 0; i < matrix.GetLength(1); i++) {
        Console.Write("*"); //prints divider for bottom
    }
}
