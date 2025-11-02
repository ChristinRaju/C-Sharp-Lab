using System;

// Abstract class (blueprint)
abstract class BankAccount
{
    protected double balance; // accessible to derived classes

    public abstract void Deposit(double amount);
    public abstract void Withdraw(double amount);

    public void ShowBalance()
    {
        Console.WriteLine("Current Balance: " + balance);
    }
}

// Derived class implementing the abstract methods
class SavingsAccount : BankAccount
{
    public override void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine(amount + " deposited successfully.");
        }
        else
        {
            Console.WriteLine("Deposit amount must be greater than 0.");
        }
    }

    public override void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance!");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be greater than 0.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine(amount + " withdrawn successfully.");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new SavingsAccount();
        int choice;

        do
        {
            Console.WriteLine("\n=== Bank Account Menu ===");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter amount to deposit: ");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    account.Deposit(depositAmount);
                    break;

                case 2:
                    Console.Write("Enter amount to withdraw: ");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    account.Withdraw(withdrawAmount);
                    break;

                case 3:
                    account.ShowBalance();
                    break;

                case 4:
                    Console.WriteLine("Thank you for using our bank!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

        } while (choice != 4);
    }
}
