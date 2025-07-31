namespace PositiveNegativeZero
{
    internal class PositiveNegativeZero
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Convert the input to an integer
            int number = int.Parse(input);

            // Check whether the number is positive, negative, or zero
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
}
