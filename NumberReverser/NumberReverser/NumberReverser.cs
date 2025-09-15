using System;

class NumberReverser
{
    private int number;
    private int reversed;

    public void ReadNumber()
    {
        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        int num = number;
        reversed = 0;

        while (num > 0)
        {
            int digit = num % 10;      // take last digit
            reversed = reversed * 10 + digit; // add digit to reverse
            num = num / 10;            // remove last digit
        }
    }

    // Method to display the reversed number
    public void Display()
    {
        Console.WriteLine($"Reverse of {number} is {reversed}");
    }
}

