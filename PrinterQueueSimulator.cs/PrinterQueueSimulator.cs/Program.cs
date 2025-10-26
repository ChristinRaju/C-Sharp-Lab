using System;
using System.Collections.Generic;
using System.Threading;

class PrinterQueueProgram
{
    static Queue<string> printerQueue = new Queue<string>();
    static ManualResetEventSlim pauseEvent = new ManualResetEventSlim(true);
    static Thread printingThread;

    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- Printer Queue Menu ---");
            Console.WriteLine("1. Add Document");
            Console.WriteLine("2. Print Next");
            Console.WriteLine("3. Print All");
            Console.WriteLine("4. Pause Printing");
            Console.WriteLine("5. Resume Printing");
            Console.WriteLine("6. Show Queue");
            Console.WriteLine("7. Exit");
            Console.Write("Choice: ");

            switch (Console.ReadLine())
            {
                case "1": AddDocument(); break;
                case "2": PrintNextDocument(); break;
                case "3": PrintAllDocuments(); break;
                case "4": PausePrinting(); break;
                case "5": ResumePrinting(); break;
                case "6": ShowQueue(); break;
                case "7": exit = true; break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }

        printingThread?.Join(); // Wait if printing is in progress
    }

    static void AddDocument()
    {
        Console.Write("Enter document name: ");
        printerQueue.Enqueue(Console.ReadLine());
        Console.WriteLine("Document added to queue.");
    }

    static void PrintNextDocument()
    {
        if (printerQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        string doc = printerQueue.Dequeue();
        printingThread = new Thread(() => PrintDocument(doc));
        printingThread.Start();
    }

    static void PrintAllDocuments()
    {
        if (printerQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        printingThread = new Thread(() =>
        {
            while (printerQueue.Count > 0)
            {
                string doc = printerQueue.Dequeue();
                PrintDocument(doc);
            }
        });
        printingThread.Start();
    }

    static void PrintDocument(string doc)
    {
        Console.WriteLine($"\nPrinting: {doc}");
        for (int i = 0; i <= 20; i++)
        {
            pauseEvent.Wait(); // Wait if paused
            Console.Write("\r[" + new string('=', i) + new string(' ', 20 - i) + $"] {i * 5}%");
            Thread.Sleep(100);
        }
        Console.WriteLine($"\n'{doc}' printed successfully!");
    }

    static void PausePrinting()
    {
        pauseEvent.Reset();
        Console.WriteLine("Printing paused.");
    }

    static void ResumePrinting()
    {
        pauseEvent.Set();
        Console.WriteLine("Printing resumed.");
    }

    static void ShowQueue()
    {
        if (printerQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        Console.WriteLine("Documents in queue:");
        foreach (var doc in printerQueue)
            Console.WriteLine("- " + doc);
    }
}
