using System;

namespace VechileApp
{
    internal class Bike : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("The bike is starting vroom vroom!");
        }

        public void Stop()
        {
            Console.WriteLine("The bike is stopping!");
        }
    }
}

// This code defines a Bike class that implements the IVehicle interface.