using System;

namespace PaymentProcessingSystem
{
    public class CreditCardPayment : Payment
    {
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }

        public CreditCardPayment(double amount, DateTime date, string cardNumber, string cardHolderName)
            : base(amount, date)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine("Processing Credit Card Payment...");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Card Holder: {CardHolderName}");
            Console.WriteLine($"Card Number: {(CardNumber)}");
            Console.WriteLine("Payment Successful via Credit Card.\n");

        }
    }
}
// This code defines a CreditCardPayment class that inherits from the Payment class and implements the ProcessPayment method.
