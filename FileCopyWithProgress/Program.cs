using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter source file path:");
        string sourceFilePath = Console.ReadLine();

        if (!File.Exists(sourceFilePath))
        {
            Console.WriteLine("Source file does not exist. Please check the path and try again.");
            return;
        }

        Console.WriteLine("Enter destination file path:");
        string destinationFilePath = Console.ReadLine();

        Console.WriteLine("Do you want to overwrite the destination file or append? (Enter 'overwrite' or 'append'):");
        string mode = Console.ReadLine().ToLower();

        bool appendMode = false;
        if (mode == "append")
        {
            appendMode = true;
        }
        else if (mode != "overwrite")
        {
            Console.WriteLine("Invalid input. Defaulting to overwrite mode.");
        }

        try
        {
            Console.WriteLine("Reading from source file...");
            string content = File.ReadAllText(sourceFilePath);
            Console.WriteLine("Read complete. Starting to write to destination file...");

            if (appendMode)
            {
                File.AppendAllText(destinationFilePath, content);
                Console.WriteLine("Content appended successfully!");
            }
            else
            {
                File.WriteAllText(destinationFilePath, content);
                Console.WriteLine("File overwritten successfully!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}