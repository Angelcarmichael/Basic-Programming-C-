using System;
using System.Collections.Generic;
using System.Text;

namespace References_Carmichael_Nathan
{
    class Sedan : IAutomobile
    {
        // An automatic property named Speed
        public double Speed { get; private set; }

        // An automatic property named Wheels
        public int Wheels { get; }

        // An automatic property named LicensePlate
        public string LicensePlate { get; }

        // A constructor that takes a double parameter
        public Sedan(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-06";
        }

        // A method that returns a string that tells what the Sedan is doing 
        public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate of {LicensePlate}");
        }
        // A method that increases Speed by 5 
        public void IncreaseSedanSpeed()
        {
            Speed += 5;
        }

        // A method that decreases Speed by 5 
        public void DecreaseSedanSpeed()
        {
            Speed -= 5;
        }
    }
}
