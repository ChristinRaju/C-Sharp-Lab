namespace HomeSecuritySystemDemo
{
    // Publisher class (Motion Sensor)
    public class MotionSensor
    {
        public delegate void MotionDetectedHandler(string message);

        public event MotionDetectedHandler MotionDetected;

        // Method to trigger the event when motion is detected
        public void DetectMotion(string location)
        {
            Console.WriteLine("Motion Sensor: Motion detected.");
            MotionDetected?.Invoke(location);
        }
    }

    // Subscriber class (Security System)
    public class SecuritySystem
    {
        public void OnMotionDetected(string location)
        {
            Console.WriteLine($"Security System: Motion detected at {location}. Notifying the homeowner...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of MotionSensor (Publisher) and SecuritySystem (Subscriber)
            MotionSensor motionSensor = new MotionSensor();
            SecuritySystem securitySystem = new SecuritySystem();

            motionSensor.MotionDetected += securitySystem.OnMotionDetected;

            motionSensor.DetectMotion("Living Room");

            motionSensor.DetectMotion("Hallway");
        }
    }
}
