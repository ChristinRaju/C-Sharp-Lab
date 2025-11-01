using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductPriceCalculator
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Enable UTF-8 encoding to correctly display ₹ symbol
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 55000 },
                new Product { Name = "Mouse", Price = 700 },
                new Product { Name = "Keyboard", Price = 1200 },
                new Product { Name = "Monitor", Price = 15000 },
                new Product { Name = "Headphones", Price = 2500 }
            };

            // LINQ queries to calculate total and average price
            double totalPrice = products.Sum(p => p.Price);
            double averagePrice = products.Average(p => p.Price);

            Console.WriteLine("----- Product Price Calculation -----");
            Console.WriteLine($"Total Price of All Products: ₹{totalPrice}");
            Console.WriteLine($"Average Price of Products: ₹{averagePrice:F2}");

        }
    }
}
