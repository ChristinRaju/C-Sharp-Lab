using System;

class SubstringDemo
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();

        // Print all substrings
        for (int start = 0; start < s.Length; start++)
        {
            for (int length = 1; length <= s.Length - start; length++)
            {
                Console.WriteLine(s.Substring(start, length));
            }
        }

        // Print total number of substrings
        Console.WriteLine("Total substrings: " + (s.Length * (s.Length + 1) / 2));
    }
}
