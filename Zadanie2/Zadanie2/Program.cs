using System;

class Calculator
{
    static void Main(string[] args)
    {
        double num1, num2, result;
        string operation;

        // Display welcome message
        Console.WriteLine("Welcome to the simple C# Calculator!");

        // Get user input for numbers and operation
        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Select an operation (+, -, *, /): ");
        operation = Console.ReadLine();

        // Perform the calculation based on the selected operation
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"The result of {num1} + {num2} is {result}");
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine($"The result of {num1} - {num2} is {result}");
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine($"The result of {num1} * {num2} is {result}");
                break;
            case "/":
                // Handle division by zero
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"The result of {num1} / {num2} is {result}");
                }
                break;
            default:
                Console.WriteLine("Invalid operation. Please select +, -, *, or /.");
                break;
        }

        // Wait for user input before closing
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
