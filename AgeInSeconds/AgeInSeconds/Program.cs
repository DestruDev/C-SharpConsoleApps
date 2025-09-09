
int age;
while (true) {
    Console.WriteLine("How old are you?: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out age))
    {
        if (age >= 0 && age <= 120) { //Checks for possible age
            break;
        } else {
            Console.WriteLine("Please enter a valid age");
        }
    } else {
        Console.WriteLine("Please enter a valid number");
    }
}
int ageInSeconds = age * 365 * 24 * 60 * 60;
Console.WriteLine("You are " + ageInSeconds + " seconds old.");
