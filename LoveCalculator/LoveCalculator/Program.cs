Console.WriteLine("Enter 1st person's name: ");
string name1 = Console.ReadLine().ToLower();
Console.WriteLine("Enter 2nd person's name: ");
string name2 = Console.ReadLine().ToLower();

int totalTrue = 0;
int totalLove = 0;
foreach (char c in name1) {
    if (c == 't' || c == 'r' || c == 'u' || c == 'e') {
        totalTrue += 1;
    }

    if (c == 'l' || c == 'o' || c == 'v' || c == 'e') {
        totalLove += 1;
    }
}

foreach (char c in name2) {
    if (c == 't' || c == 'r' || c == 'u' || c == 'e') {
        totalTrue += 1;
    }

    if (c == 'l' || c == 'o' || c == 'v' || c == 'e') {
        totalLove += 1;
    }
}

Console.WriteLine("True love percentage = " + totalTrue.ToString() + totalLove.ToString());