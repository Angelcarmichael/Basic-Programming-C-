using System;
using System.Collections.Generic;
using System.Text;

namespace References_Carmichael_Nathan
{
    class Truck : IAutomobile
    {
        // An automatic property named Speed
        public double Speed { get; private set; }

        // An automatic property named Wheels
        public int Wheels { get; }

        // An automatic property named LicensePlate
        public string LicensePlate { get; }

        // An automatic property named Weight
        public double Weight { get; }

        // A constructor that takes three double parameters
        public Truck(double speed, double weight)
        {
            Speed = speed;
            Weight = weight;
            LicensePlate = "KGA-16";

            if (Weight < 400)
            {
                Wheels = 8; 
            }
            else
            {
                Wheels = 12;
            }
        }

        // A method that returns a string that tells what the Truck is doing 
        public void Stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate of {LicensePlate}");
        }

        // A method that increases Speed by 5 
        public void IncreaseTruckSpeed()
        {
            Speed += 5;
        }

        // A method that decreases Speed by 5 
        public void DecreaseTruckSpeed()
        {
            Speed -= 5;
        }
    }
}
