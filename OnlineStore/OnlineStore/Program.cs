using System;

namespace OnlineStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone phone = new Smartphone(
                "iPhone 13 Pro Max",
                2000,
                "Apple",
                2,
                "iOS",
                256
            );

            Console.WriteLine("Product Details:");
            phone.DisplayDetails();

            Console.ReadLine();
        }
    }
}
// This code defines a simple online store application that creates a smartphone product and displays its details.