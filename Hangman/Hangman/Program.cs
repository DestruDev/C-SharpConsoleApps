int count = 6;
PrintHangman(count);
Console.WriteLine("Welcome to Hangman, Choose a word: ");
string chosenWord = Console.ReadLine().ToLower();
char[] dashedWord = new char[chosenWord.Length];
bool solved = false;
for (int i = 0; i < chosenWord.Length; i++) {
    dashedWord[i] = '_';
}

HashSet<char> remainingLetters = new HashSet<char>(chosenWord);
while (!solved) {
    Console.WriteLine("Clues: " + string.Join(" ", dashedWord));
    Console.WriteLine("Guess a character: ");
    string chosenLetter = Console.ReadLine();
    if (char.TryParse(chosenLetter, out char guess)) {
        if (remainingLetters.Contains(guess)) {
            Console.WriteLine("Correct character!");
            
            // Reveal guessed letters
            for (int i = 0; i < chosenWord.Length; i++) {
                if (chosenWord[i] == guess) {
                    dashedWord[i] = guess;
                }
            }

            remainingLetters.Remove(guess); // Remove from tracking set

        } else {
            Console.WriteLine("Incorrect character.");
            count--;
            
        }
    } else {
        Console.WriteLine("Invalid input. Please enter a single character.");
    }
    PrintHangman(count);
    // Check if the player has guessed all letters
    if (!new string(dashedWord).Contains('_')) {
        solved = true;
        Console.WriteLine("You won! The word was: " + chosenWord);
    }

    if (count == 0) {
        Console.WriteLine("You Lose!");
        solved = true;
    }
}

static void PrintHangman(int limbs) {
    
    Console.WriteLine("_______");
    Console.WriteLine("|     |");
    Console.WriteLine("|     |");
    if (limbs >= 1) {
        Console.WriteLine(("|     O"));
    }
    if (limbs >= 4) {
        Console.WriteLine(("|    -|-"));

    } else if (limbs >= 3) { 
        Console.WriteLine(("|    -|"));

    } else if (limbs >= 2) {
        Console.WriteLine(("|     |"));

    }
    if (limbs == 6) {
        Console.WriteLine("|    /|");
    } else if (limbs >= 5) {
        Console.WriteLine(("|    /"));
    }
    
    Console.WriteLine("|     ");
    Console.WriteLine("|     ");
    Console.WriteLine("|     ");
    Console.WriteLine("|     ");
}
        
