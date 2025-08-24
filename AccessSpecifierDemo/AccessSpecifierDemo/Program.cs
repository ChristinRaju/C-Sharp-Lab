using System;

namespace AccessSpecifierDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount("Christin Raju", 93750.00, "State Bank of India", "SBIN0000456", "Connaught Place, New Delhi", "Savings");
            SavingsAccount savings = new SavingsAccount("Christin Raju", 93750.00, "State Bank of India", "SBIN0000456", "Connaught Place, New Delhi", "Savings");
            OtherClass other = new OtherClass(acc);

            Console.WriteLine("--- Accessing from Main ---");
            Console.WriteLine($"Account Holder: {acc.AccountHolder}"); // Public
            acc.ShowBalance(); // Private via public method
            Console.WriteLine($"IFSC Code: {acc.IFSCCode}"); // Internal
            Console.WriteLine($"Branch: {acc.Branch}"); // Protected Internal

            savings.DisplayAccessibleMembers();
            other.DisplayAccessibleMembers();
        }
    }
}
