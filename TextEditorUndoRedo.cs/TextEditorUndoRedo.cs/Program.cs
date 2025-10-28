using System;
using System.Collections.Generic;

class TextEditorSimulator
{
    static Stack<string> undoStack = new Stack<string>();
    static Stack<string> redoStack = new Stack<string>();
    static string text = "";

    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- Text Editor ---");
            Console.WriteLine("1. Type Text");
            Console.WriteLine("2. Undo");
            Console.WriteLine("3. Redo");
            Console.WriteLine("4. Show Text");
            Console.WriteLine("5. Exit");
            Console.Write("Choice: ");

            switch (Console.ReadLine())
            {
                case "1": TypeText(); break;
                case "2": Undo(); break;
                case "3": Redo(); break;
                case "4": ShowText(); break;
                case "5": exit = true; break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }

    static void TypeText()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        // Save current state for undo
        undoStack.Push(text);

        // Clear redo stack because new action invalidates future states
        redoStack.Clear();

        // Append text with newline for proper formatting
        text += input + Environment.NewLine;
        Console.WriteLine("Text added.");
    }

    static void Undo()
    {
        if (undoStack.Count == 0)
        {
            Console.WriteLine("Nothing to undo.");
            return;
        }

        // Save current state for redo
        redoStack.Push(text);

        // Revert to previous state
        text = undoStack.Pop();
        Console.WriteLine("Undo performed.");
    }

    static void Redo()
    {
        if (redoStack.Count == 0)
        {
            Console.WriteLine("Nothing to redo.");
            return;
        }

        // Save current state for undo
        undoStack.Push(text);

        // Restore state from redo stack
        text = redoStack.Pop();
        Console.WriteLine("Redo performed.");
    }

    static void ShowText()
    {
        Console.WriteLine("\nCurrent Text:");
        Console.WriteLine(text == "" ? "(empty)" : text);
    }
}
