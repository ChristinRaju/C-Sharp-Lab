using System;

class SquareCalculator
{
    private int number;

    public void ReadNumber()
    {
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
    }

    // Method to calculate and display square
    public void DisplaySquare()
    {
        int square = number * number;
        Console.WriteLine($"Square of {number} is {square}");
    }
}