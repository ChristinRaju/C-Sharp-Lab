using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        int choice = 0;

        do
        {
            Console.WriteLine("\n=== Stack Operations Menu ===");
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Peek (View Top Element)");
            Console.WriteLine("4. Display Stack");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            // Read choice safely
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number between 1-5.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter number to push: ");
                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        stack.Push(num);
                        Console.WriteLine(num + " pushed to stack.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                    }
                    break;

                case 2:
                    if (stack.Count > 0)
                        Console.WriteLine(stack.Pop() + " popped from stack.");
                    else
                        Console.WriteLine("Stack is empty. Nothing to pop.");
                    break;

                case 3:
                    if (stack.Count > 0)
                        Console.WriteLine("Top element: " + stack.Peek());
                    else
                        Console.WriteLine("Stack is empty.");
                    break;

                case 4:
                    if (stack.Count > 0)
                    {
                        Console.WriteLine("Stack elements (top to bottom):");
                        foreach (int item in stack)
                            Console.WriteLine(item);
                    }
                    else
                    {
                        Console.WriteLine("Stack is empty.");
                    }
                    break;

                case 5:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select 1–5.");
                    break;
            }

        } while (choice != 5);
    }
}
