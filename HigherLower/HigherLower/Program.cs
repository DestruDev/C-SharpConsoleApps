using System;
int numbR;
while (true) {
    Console.WriteLine("Hello, Welcome to Higher/Lower! Enter your number range: ");
    string numRange = Console.ReadLine();

    if (int.TryParse(numRange, out numbR)) {
        break;
    } else {
        Console.WriteLine("Please enter a number.");
    }
}


Random rand = new Random();
int randNum = rand.Next(1, numbR + 1);
int guessNum;
int tries = 0;

while (true) {
    Console.WriteLine($"Guess a number between 1 and {numbR}:");
    string guessedNum = Console.ReadLine();

    if (int.TryParse(guessedNum, out guessNum)) {
        tries++;

        if (guessNum == randNum) {
            Console.WriteLine($"Correct! You got it in {tries} {(tries > 1 ? "tries" : "try")}.");
            Console.WriteLine("The number was " + randNum);
            break;
        } else if (guessNum > randNum) { 
            Console.WriteLine("Too high! Try again.");
        } else {
            Console.WriteLine("Too low! Try again.");
        }
    } else {
        Console.WriteLine("Please enter a valid number.");
    }
}   
