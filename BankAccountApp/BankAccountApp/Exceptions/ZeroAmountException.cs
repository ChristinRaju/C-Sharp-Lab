using System;

namespace BankAccountApp.Exceptions
{
    public class ZeroAmountException : Exception
    {
        public ZeroAmountException(string message) : base(message) { }
    }
}

