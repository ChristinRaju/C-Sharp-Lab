using System;

class SimpleCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Simple Arithmetic Calculator ===");

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        double result = 0;
        bool validOperation = true;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    validOperation = false; // mark invalid
                }
                else
                {
                    result = num1 / num2;
                }
                break;

            default:
                Console.WriteLine("Invalid operation.");
                validOperation = false; // mark invalid
                break;
        }

        if (validOperation)
            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
    }
}
