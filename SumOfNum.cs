namespace SumOfNum
{
    internal class SumOfNum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Convert the input to an integer
            int number = int.Parse(input);

            // Initialize the sum of digits
            int sum = 0;

            // Loop through each digit of the number
            while (number != 0)
            {
                sum += number % 10;  // Add the last digit of the number to sum
                number /= 10;         // Remove the last digit from the number
            }

            // Output the result
            Console.WriteLine("Sum of digits: " + sum);
        }
    }
}
