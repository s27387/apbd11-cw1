using System;

class FactorialCalculator
{
    static void Main(string[] args)
    {
        int number;
        long factorial = 1;

        // Display welcome message
        Console.WriteLine("Welcome to the Factorial Calculator!");

        // Get user input for the number
        Console.Write("Enter a number to calculate its factorial: ");
        number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is negative
        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            // Calculate the factorial
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            // Display the result
            Console.WriteLine($"The factorial of {number} is {factorial}");
        }

        // Wait for user input before closing
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
