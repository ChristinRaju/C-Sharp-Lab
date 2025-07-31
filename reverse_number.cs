namespace reverse_number
{
    internal class reverse_number
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int reversedNumber = 0;

            // Reverse the digits of the number
            while (number != 0)
            {
                int digit = number % 10; // Get the last digit
                reversedNumber = reversedNumber * 10 + digit; // Append the digit to reversedNumber
                number = number / 10; // Remove the last digit from the original number
            }

            // Output the reversed number
            Console.WriteLine($"The reversed number is: {reversedNumber}");
        }
    }
}
