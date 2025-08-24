using System;

namespace AccessSpecifierDemo
{
    public class BankAccount
    {
        public string AccountHolder;              // Public
        private double Balance;                   // Private
        protected string BankName;                // Protected
        internal string IFSCCode;                 // Internal
        protected internal string Branch;         // Protected Internal
        private protected string AccountType;     // Private Protected

        public BankAccount(string accountHolder, double balance, string bankName, string ifsc, string branch, string accountType)
        {
            AccountHolder = accountHolder;
            Balance = balance;
            BankName = bankName;
            IFSCCode = ifsc;
            Branch = branch;
            AccountType = accountType;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}
