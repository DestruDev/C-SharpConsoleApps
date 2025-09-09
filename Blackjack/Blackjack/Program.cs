Random rand = new Random();
int dealerCard = rand.Next(1, 10);
int playerCard1 = rand.Next(1, 10);
int playerCard2 = rand.Next(1, 10);
int playerTotal = playerCard1 + playerCard2;
int dealerTotal = dealerCard;
string playerCards = playerCard1.ToString() + " " + playerCard2.ToString();
string dealerCards = dealerCard.ToString();
Console.WriteLine("Dealer: " + dealerCards + " Total: " + dealerTotal.ToString());
Console.WriteLine("Player: " + playerCards + " Total: " + playerTotal.ToString());
int output;
bool gameEnded = false;
int output2;
while (!gameEnded) {
    Console.WriteLine("Enter 1 for Hit or 2 for Stand: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out output)) {
        if (output == 1) {
            int playerCardn = rand.Next(1, 10);
            if (playerCardn == 1) {
                while (true) {
                    Console.WriteLine("You hit an Ace! Choose 1 or 11. Type 1 for 1, or 2 for 11");
                    string input2 = Console.ReadLine();
                    if (int.TryParse(input2, out output2)) { 
                        if (output2 == 1) {
                            playerCardn = 1;
                            break;
                        } else if (output2 == 2) {
                            playerCardn = 11;
                            break;
                        }
                    }
                    Console.WriteLine("Please enter a valid action: "); 
                }
            }
            playerTotal += playerCardn;
            playerCards += " " + playerCardn.ToString();
            Console.WriteLine("Dealer: " + dealerCards + " Total: " + dealerTotal.ToString());
            Console.WriteLine("Player: " + playerCards + " Total: " + playerTotal.ToString());
            if (playerTotal > 21) {
                Console.WriteLine("Player busted! You lose!");
                gameEnded = true;
                break;
            }
        } else if (output == 2) {   
            break;
        } else {
            Console.WriteLine("Please enter a valid action: ");
        }
    }
}
if (!gameEnded) {
    while (dealerTotal < playerTotal && dealerTotal < 17) {
        int dealerCardn = rand.Next(1, 10);
        dealerTotal += dealerCardn;
        dealerCards += " " + dealerCardn.ToString();
        Console.WriteLine("Dealer: " + dealerCards + " Total: " + dealerTotal.ToString());
    }
    if (dealerTotal == playerTotal) {
        Console.WriteLine("Tie game.");
    }
    if (dealerTotal > 21) {
        Console.WriteLine("Dealer busted. You win!");
    } else if (dealerTotal > playerTotal && dealerTotal < 22) {
        Console.WriteLine("You lose!");
    }
}

