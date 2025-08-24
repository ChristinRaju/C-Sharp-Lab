using System;

namespace AccessSpecifierDemo
{
    public class OtherClass
    {
        BankAccount account;

        public OtherClass(BankAccount acc)
        {
            account = acc;
        }

        public void DisplayAccessibleMembers()
        {
            Console.WriteLine("\n--- Inside Non-Derived Class (OtherClass) ---");

            Console.WriteLine($"Account Holder: {account.AccountHolder}");  // Public
            // Console.WriteLine(account.Balance); ❌ Not Accessible
            // Console.WriteLine(account.BankName); ❌ Not Accessible
            Console.WriteLine($"IFSC Code: {account.IFSCCode}");            // Internal
            Console.WriteLine($"Branch: {account.Branch}");                 // Protected Internal
            // Console.WriteLine(account.AccountType); ❌ Not Accessible
        }
    }
}
