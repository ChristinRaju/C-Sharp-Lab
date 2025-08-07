using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace VechileApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create instances of each vehicle type
            IVehicle myCar = new Car();
            IVehicle myBike = new Bike();

            // Start and Stop each vehicle
            Console.WriteLine("Vehicle Operations:");

            Console.WriteLine("Car:");
            myCar.Start();
            myCar.Stop();

            Console.WriteLine("\nBike:");
            myBike.Start();
            myBike.Stop();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
// This code defines a Program class with a Main method that creates instances of Car and Bike,



