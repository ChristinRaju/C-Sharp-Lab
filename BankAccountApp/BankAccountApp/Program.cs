using BankAccountApp.Exceptions;
using System;

namespace BankAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 5000.0;

            Console.WriteLine("Initial Balance: " + balance);
            Console.Write("Enter withdrawal amount: ");

            try
            {
                double withdrawal = Convert.ToDouble(Console.ReadLine());

                if (withdrawal < 0)
                {
                    throw new NegativeAmountException("Error: Withdrawal amount cannot be negative!");
                }
                else if (withdrawal == 0)
                {
                    throw new ZeroAmountException("Error: Withdrawal amount cannot be zero!");
                }
                else if (withdrawal > balance)
                {
                    throw new InsufficientFundsException("Error: Withdrawal amount exceeds available balance!");
                }

                balance -= withdrawal;
                Console.WriteLine("Withdrawal successful.");
                Console.WriteLine("Updated Balance: " + balance);
            }
            catch (NegativeAmountException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ZeroAmountException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric amount.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }
    }
}

