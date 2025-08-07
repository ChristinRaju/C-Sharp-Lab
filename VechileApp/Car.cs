using System;

namespace VechileApp
{
    public class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("The car is starting!");
        }

        public void Stop()
        {
            Console.WriteLine("The car is stopping with smooth brakes.");
        }
    }
}

// This code defines a Car class that implements the IVehicle interface.