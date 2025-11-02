using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        string reversedWords = string.Join(" ", input
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Reverse());

        Console.WriteLine("Reversed sentence: " + reversedWords);
    }
}
