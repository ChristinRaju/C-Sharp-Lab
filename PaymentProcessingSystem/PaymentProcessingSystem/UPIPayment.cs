using System;

namespace PaymentProcessingSystem
{
    public class UPIPayment : Payment
    {
        public string UpiId { get; set; }
        public string BankName { get; set; }

        public UPIPayment(double amount, DateTime date, string upiId, string bankName)
            : base(amount, date)
        {
            UpiId = upiId;
            BankName = bankName;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine("Processing UPI Payment...");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"UPI ID: {UpiId}");
            Console.WriteLine($"Bank: {BankName}");
            Console.WriteLine("Payment Successful via UPI.\n"); 
        }
    }
}
// This code defines a UPIPayment class that inherits from the Payment class and implements the ProcessPayment method.
