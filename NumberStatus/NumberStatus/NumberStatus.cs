using System;

class NumberStatus
{
    private int number;

    public void ReadNumber()
    {
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
    }

    // Method to check and display result
    public void DisplayStatus()
    {
        if (number > 0)
            Console.WriteLine($"{number} is Positive.");
        else if (number < 0)
            Console.WriteLine($"{number} is Negative.");
        else
            Console.WriteLine("The number is Zero.");
    }
}