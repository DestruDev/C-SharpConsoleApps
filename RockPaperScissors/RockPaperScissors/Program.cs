Console.WriteLine("Welcome to Rock, Paper, Scissors");
string input1;
string input2;
while (true) {
    Console.WriteLine("First player, Please choose rock, paper, or scissors");
    input1 = Console.ReadLine().ToLower();
    if (input1 == "rock" || input1 == "paper" || input1 == "scissors") {
        break;
    } else {
        Console.WriteLine("Enter a valid play: ");
    }
}

while (true) {
    Console.WriteLine("Second player, Please choose rock, paper, or scissors");
    input2 = Console.ReadLine().ToLower();
    if (input2 == "rock" || input2 == "paper" || input2 == "scissors") {
        break;
    } else {
        Console.WriteLine("Enter a valid play: ");
    }

}

if (input1 == "rock" && input2 == "scissors") {
    Console.WriteLine("Player 1 wins!");
}else if (input1 == input2) {
    Console.WriteLine("Tie!");
} else if (input2 == "rock" && input1 == "scissors") {
    Console.WriteLine("Player 2 wins!");
} else if (input1 == "paper" && input2 == "scissors") {
    Console.WriteLine("Player 2 wins!");
} else if (input2 == "paper" && input1 == "scissors") {
    Console.WriteLine("Player 1 wins!");
} else if (input1 == "paper" && input2 == "rock") {
    Console.WriteLine("Player 1 wins!");
} else if (input2 == "paper" && input1 == "rock") {
    Console.WriteLine("Player 2 wins!");
}