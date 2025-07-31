namespace sumofnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            // Calculate the sum of digits
            while (number != 0)
            {
                int digit = number % 10; // Extract the last digit
                sum += digit; // Add the digit to sum
                number /= 10; // Remove the last digit from the number
            }

            // Output the sum of digits
            Console.WriteLine($"The sum of the digits is: {sum}");
        }
    }
}
