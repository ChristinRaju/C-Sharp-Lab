using System;

namespace CalculatorExceptionDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // Accept first number
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                // Accept second number
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Accept operation
                Console.Write("Enter operation (+, -, *, /): ");
                char op = Convert.ToChar(Console.ReadLine());

                double result = 0;

                switch (op)
                {
                    case '+': result = num1 + num2; break;
                    case '-': result = num1 - num2; break;
                    case '*': result = num1 * num2; break;
                    case '/':
                        if (num2 == 0)
                            throw new DivideByZeroException();
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        return;
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Please enter numeric values only.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Calculation attempt completed.");
            }
        }
    }
}
