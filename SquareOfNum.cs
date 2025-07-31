namespace SquareOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Calculate the square of the number
            int square = number * number;

            // Display the result
            Console.WriteLine("The square of " + number + " is: " + square);
        }
    }
}


