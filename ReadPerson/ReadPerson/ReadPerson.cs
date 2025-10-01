using System;

class Person
{
    private string name;
    private int age;

    // Method to read person details
    public void ReadPerson()
    {
        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());
    }

    // Method to display person details
    public void DisplayPerson()
    {
        Console.WriteLine("\n--- Person Details ---");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age : {age}");
    }
}