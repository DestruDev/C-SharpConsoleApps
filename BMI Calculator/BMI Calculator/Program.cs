double output1;

double output2;

while (true) {
    Console.WriteLine("Enter your weight in kilograms: ");
    string weight = Console.ReadLine();
    if (double.TryParse(weight, out output1)) {
        break;
    } else {
        Console.WriteLine("Enter a valid weight.");
    }
}

while (true) {
    Console.WriteLine("Enter your height in meters: ");
    string height = Console.ReadLine();
    if (double.TryParse(height, out output2)) {
        break;
    } else {
        Console.WriteLine("Enter a valid height.");
    }
}

Console.WriteLine("Your BMI is: " + (output1 / (output2 * output2)));