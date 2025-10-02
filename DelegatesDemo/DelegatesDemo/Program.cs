public class Program
{
    // Step 1: Declare delegate
    public delegate void PrintMessage(string message);

    // Step 2: Method with same signature
    static void SayHello(string message)
    {
        Console.WriteLine("Hello, " + message);
    }

    public static void Main()
    {
        // Step 3: Create delegate object
        PrintMessage del = SayHello;

        // Step 4: Call delegate
        del("Students");
    }
}
