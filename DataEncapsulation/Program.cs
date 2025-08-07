using System;

namespace DataEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Person object
            Person person = new Person();

            // Get Name and Age
            Console.Write("Enter name: ");
            person.Name = Console.ReadLine();

            Console.Write("Enter age: ");
            person.Age = int.Parse(Console.ReadLine());

            // Display the details
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
// This code creates a simple console application that allows the user to input a person's name and age,


