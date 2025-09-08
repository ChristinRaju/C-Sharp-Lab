using System;

class ExceptionDemo
{
    static void Main()
    {
        Console.WriteLine("=== Exception Handling Demo ===");

        // Division by Zero
        try
        {
            Console.Write("Enter numerator: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int den = Convert.ToInt32(Console.ReadLine());

            int result = num / den;   // May throw DivideByZeroException
            Console.WriteLine($"Result = {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine(); // spacing

        // Index Out of Range
        try
        {
            int[] arr = { 10, 20, 30 };

            Console.Write("Enter index (0-2) to access array element: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Value at index {index} = {arr[index]}"); // May throw IndexOutOfRangeException
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("\nProgram completed.");
    }
}
