using System;

namespace HomeSecuritySystemDemo
{
    // Custom EventArgs class to hold event data
    public class MotionEventArgs : EventArgs
    {
        public string Location { get; }

        public MotionEventArgs(string location)
        {
            Location = location;
        }
    }

    // Publisher class (Motion Sensor)
    public class MotionSensor
    {
        // Declare event using built-in EventHandler<T>
        public event EventHandler<MotionEventArgs>? MotionDetected;

        // Method to trigger the event
        public void DetectMotion(string location)
        {
            Console.WriteLine("Motion Sensor: Motion detected.");
            OnMotionDetected(new MotionEventArgs(location));
        }

        // Protected virtual method to raise the event
        protected virtual void OnMotionDetected(MotionEventArgs e)
        {
            MotionDetected?.Invoke(this, e);
        }
    }

    // Subscriber class (Security System)
    public class SecuritySystem
    {
        public void OnMotionDetected(object? sender, MotionEventArgs e)
        {
            Console.WriteLine($"Security System: Motion detected at {e.Location}. Notifying the homeowner...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances
            MotionSensor motionSensor = new MotionSensor();
            SecuritySystem securitySystem = new SecuritySystem();

            // Subscribe to the event
            motionSensor.MotionDetected += securitySystem.OnMotionDetected;

            // Simulate motion detection
            motionSensor.DetectMotion("Living Room");
            motionSensor.DetectMotion("Hallway");
        }
    }
}
