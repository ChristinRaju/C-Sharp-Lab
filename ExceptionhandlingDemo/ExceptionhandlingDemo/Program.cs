namespace ExceptionhandlingDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int x = 10;
                int y = 0;

                int result = x / y;
                Console.WriteLine($"Result: {result}");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }

        }
    }
}
