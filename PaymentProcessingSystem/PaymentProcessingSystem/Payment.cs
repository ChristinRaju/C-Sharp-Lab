using System;

namespace PaymentProcessingSystem
{
    public abstract class Payment
    {
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        protected Payment(double amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }

        public abstract void ProcessPayment();
    }
}
// This code defines an abstract class Payment that serves as a base class for different payment methods.