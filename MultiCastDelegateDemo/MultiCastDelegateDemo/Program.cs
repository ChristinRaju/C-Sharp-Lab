using System;

namespace MultiCastDelegateDemo
{
    public class Program
    {
        // Create a delegate that can hold methods with a string input
        public delegate void Notify(string name);

        // Method 1: Welcome message
        static void Welcome(string name)
        {
            Console.WriteLine("Welcome to the Multicast Delegate Demo!");
        }

        // Method 2: Say hello
        static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        // Method 3: Say goodbye
        static void Goodbye(string name)
        {
            Console.WriteLine($"Goodbye, {name}!");
        }

        public static void Main(string[] args)
        {
            // Step 1: Assign first method to delegate
            Notify del = Welcome;

            // Step 2: Add more methods to delegate
            del += Greet;
            del += Goodbye;

            // Step 3: Call delegate (all methods run)
            del("Alice");

            // Step 4: Remove one method
            del -= Greet;

            // Step 5: Call delegate again (only Welcome + Goodbye run)
            del("Bob");
        }
    }
}
