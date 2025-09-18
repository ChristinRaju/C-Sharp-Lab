//Develop a C# program to read a text file and copy the file contents to another text file.

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string sourceFilePath = "source.txt"; // Path to the source file
        string destinationFilePath = "destination.txt"; // Path to the destination file

        try
        {
            // Read all text from the source file
            string content = File.ReadAllText(sourceFilePath);

            // Write the content to the destination file
            File.WriteAllText(destinationFilePath, content);

            Console.WriteLine("File copied successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Source file not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
