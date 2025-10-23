using System;

namespace EventHandlerDemo
{
    // Publisher class
    public class Publisher
    {
        // Define the delegate
        public delegate void MyEventHandler(string message);

        // Declare the event using the delegate
        public event MyEventHandler OnChange;

        // Method to trigger the event
        public void TriggerEvent(string msg)
        {
            Console.WriteLine("Publisher: Event triggered");
            if(OnChange != null )
                OnChange(msg);
        }
    }

    // Subscriber class
    public class Subscriber
    {
        public void HandleEvent(string message)
        {
            Console.WriteLine($"Subscriber: Received message - {message}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Publisher and Subscriber
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            publisher.OnChange += subscriber.HandleEvent;

            publisher.TriggerEvent("Hello, C# event.");
        }
    }
}
