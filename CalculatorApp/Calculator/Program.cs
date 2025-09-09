double number1;
double number2;
while (true) {
    Console.WriteLine("Enter your first number: ");
    string input1 = Console.ReadLine();

    if (double.TryParse(input1, out number1)) {
        break;
    } else {
        Console.WriteLine("Please enter a valid number");
    }
}
while (true) {
    Console.WriteLine("Enter your second number: ");
    string input2 = Console.ReadLine();

    if (double.TryParse(input2, out number2)) {
        break;
    } else {
        Console.WriteLine("Please enter a valid number");
    }

}
string operation;

while (true) {
    Console.WriteLine("Enter a mathematical operation. (+, -, *, /): ");
    operation = Console.ReadLine();

    if (operation == "*" || operation == "-" || operation == "+" || operation == "/" ) { //Check for valid operation
        break;
    } else {
        Console.WriteLine("Please enter a valid operation");
    }
}
double result = 0;
switch (operation) {
    case "+":
        result = number1 + number2;
        break;
    case "-":
        result = number1 - number2;
        break;
    case "*":
        result = number1 * number2;
        break;
    case "/":
        result = number1 / number2;
        break;
    default:
        Console.WriteLine("ERROR: You did not enter an operation");
        break;
}

Console.WriteLine($"{number1} {operation} {number2} = " +  result);


