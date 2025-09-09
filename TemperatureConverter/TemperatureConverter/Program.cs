
double input;
while (true) {
    Console.WriteLine("Enter the temperature (in Celcius).");
    string celcius = Console.ReadLine();

    if(double.TryParse(celcius, out input)){
        break;
    } else {
        Console.WriteLine("Please enter a valid number.");
    }
}
double fahrenheit = input * 1.80 + 32.00;
Console.WriteLine("The temperature is " + fahrenheit + "F°");
