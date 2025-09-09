int output;
while (true) {
    Console.WriteLine("Enter a number.");
    string n = Console.ReadLine();
    if (int.TryParse(n, out output)) {
        if (output % 3 == 0 && output % 5 == 0) {
            Console.WriteLine("FizzBuzz");
        } else if (output % 3 == 0) {
            Console.WriteLine("Fizz");
        } else {
            Console.WriteLine("Buzz");
        }
        
    } else {
        Console.WriteLine("Not divisible by 3 or 5.");
    }
}