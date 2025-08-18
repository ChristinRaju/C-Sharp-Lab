using System;

namespace OnlineStore
{
    public class Smartphone : ElectronicProduct
    {
        public string OS { get; set; }
        public int Storage { get; set; } // GB

        public Smartphone(string name, double price, string brand, int warranty, string os, int storage)
            : base(name, price, brand, warranty)
        {
            OS = os;
            Storage = storage;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"OS: {OS}");
            Console.WriteLine($"Storage: {Storage} GB");
        }
    }
}
// This code defines a Smartphone class that inherits from ElectronicProduct.