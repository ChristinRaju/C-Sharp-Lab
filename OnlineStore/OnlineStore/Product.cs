using System;

namespace OnlineStore
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Product: {Name}");
            Console.WriteLine($"Price: ${Price}");

        }
    }
}
// This code defines a Product class with properties for the product name and price, and a method to display its details.
