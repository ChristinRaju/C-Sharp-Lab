using System;

namespace PaymentProcessingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment ccPayment = new CreditCardPayment(10000, DateTime.Now, "12345678987654321", "Christin Raju");
            ccPayment.ProcessPayment();

            Payment upiPayment = new UPIPayment(500, DateTime.Now, "christin@upi", "ABC Bank");
            upiPayment.ProcessPayment();

            Console.ReadLine();
        }
    }
}
// This code defines a simple payment processing system that demonstrates polymorphism by processing
// different types of payments (credit card and UPI).
