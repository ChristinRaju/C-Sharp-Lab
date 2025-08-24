using System;

namespace AccessSpecifierDemo
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolder, double balance, string bankName, string ifsc, string branch, string accountType)
            : base(accountHolder, balance, bankName, ifsc, branch, accountType)
        {
        }

        public void DisplayAccessibleMembers()
        {
            Console.WriteLine("\n--- Inside Derived Class (SavingsAccount) ---");

            Console.WriteLine($"Account Holder: {AccountHolder}");   // Public
            // Console.WriteLine(Balance); ❌ Not Accessible
            Console.WriteLine($"Bank Name: {BankName}");             // Protected
            Console.WriteLine($"IFSC Code: {IFSCCode}");             // Internal
            Console.WriteLine($"Branch: {Branch}");                  // Protected Internal
            Console.WriteLine($"Account Type: {AccountType}");       // Private Protected
        }
    }
}
