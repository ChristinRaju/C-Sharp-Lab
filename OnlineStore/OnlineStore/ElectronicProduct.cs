using System;

namespace OnlineStore
{
    public class ElectronicProduct : Product
    {
        public string Brand { get; set; }
        public int Warranty { get; set; } // years

        public ElectronicProduct(string name, double price, string brand, int warranty)
            : base(name, price)
        {
            Brand = brand;
            Warranty = warranty;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Warranty: {Warranty} year(s)");
        }
    }
}
// This code defines an ElectronicProduct class that inherits from Product.