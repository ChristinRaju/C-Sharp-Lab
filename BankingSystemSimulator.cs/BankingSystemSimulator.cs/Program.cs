using System;
using System.Collections.Generic;

class BankingSystem
{
    // Customer class
    class Customer
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public Customer(string name)
        {
            Name = name;
            Balance = 0;
        }
    }

    // Transaction class for undo
    class Transaction
    {
        public Customer Customer { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; } // "Deposit" or "Withdraw"
    }

    static Queue<Customer> customerQueue = new Queue<Customer>();
    static Stack<Transaction> transactionStack = new Stack<Transaction>();

    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- Banking System ---");
            Console.WriteLine("1. Add Customer to Queue");
            Console.WriteLine("2. Serve Next Customer");
            Console.WriteLine("3. Undo Last Transaction");
            Console.WriteLine("4. Show Queue");
            Console.WriteLine("5. Exit");
            Console.Write("Choice: ");

            switch (Console.ReadLine())
            {
                case "1": AddCustomer(); break;
                case "2": ServeCustomer(); break;
                case "3": UndoTransaction(); break;
                case "4": ShowQueue(); break;
                case "5": exit = true; break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }

    static void AddCustomer()
    {
        Console.Write("Enter customer name: ");
        string name = Console.ReadLine();
        customerQueue.Enqueue(new Customer(name));
        Console.WriteLine($"Customer '{name}' added to queue.");
    }

    static void ServeCustomer()
    {
        if (customerQueue.Count == 0)
        {
            Console.WriteLine("No customers in queue.");
            return;
        }

        Customer currentCustomer = customerQueue.Dequeue();
        Console.WriteLine($"\nServing Customer: {currentCustomer.Name}");
        Console.WriteLine($"Current Balance: {currentCustomer.Balance:C}");

        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.Write("Choose operation: ");
        string choice = Console.ReadLine();

        Console.Write("Enter amount: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount) || amount <= 0)
        {
            Console.WriteLine("Invalid amount!");
            return;
        }

        switch (choice)
        {
            case "1":
                currentCustomer.Balance += amount;
                transactionStack.Push(new Transaction { Customer = currentCustomer, Amount = amount, Type = "Deposit" });
                Console.WriteLine($"Deposited {amount:C}. New Balance: {currentCustomer.Balance:C}");
                break;

            case "2":
                if (currentCustomer.Balance >= amount)
                {
                    currentCustomer.Balance -= amount;
                    transactionStack.Push(new Transaction { Customer = currentCustomer, Amount = amount, Type = "Withdraw" });
                    Console.WriteLine($"Withdrew {amount:C}. New Balance: {currentCustomer.Balance:C}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance!");
                }
                break;

            default:
                Console.WriteLine("Invalid operation!");
                break;
        }

        // Put customer back at the end of queue
        customerQueue.Enqueue(currentCustomer);
    }

    static void UndoTransaction()
    {
        if (transactionStack.Count == 0)
        {
            Console.WriteLine("No transaction to undo.");
            return;
        }

        Transaction lastTransaction = transactionStack.Pop();
        if (lastTransaction.Type == "Deposit")
        {
            lastTransaction.Customer.Balance -= lastTransaction.Amount;
            Console.WriteLine($"Undo Deposit: {lastTransaction.Amount:C} removed from {lastTransaction.Customer.Name}'s account.");
        }
        else if (lastTransaction.Type == "Withdraw")
        {
            lastTransaction.Customer.Balance += lastTransaction.Amount;
            Console.WriteLine($"Undo Withdraw: {lastTransaction.Amount:C} added back to {lastTransaction.Customer.Name}'s account.");
        }

        Console.WriteLine($"Current Balance: {lastTransaction.Customer.Balance:C}");
    }

    static void ShowQueue()
    {
        if (customerQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        Console.WriteLine("Customers in Queue:");
        foreach (var customer in customerQueue)
            Console.WriteLine($"- {customer.Name} (Balance: {customer.Balance:C})");
    }
}

