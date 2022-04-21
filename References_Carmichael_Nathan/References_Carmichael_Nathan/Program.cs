using System;

namespace References_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates an instance of the Sedan class
             Sedan s = new Sedan(10);

            // Creates an instance of the IAutomobile interface
            IAutomobile i = s;

            // Creates another instance of the Sedan class
            Sedan s2 = new Sedan(20);

            // Calls the IncreaseSedanSpeed method 
            s.IncreaseSedanSpeed();

            // Tells the user the speed of the first Sedan 
            Console.WriteLine($"The speed of the first Sedan is {s.Speed}");

            // Tells the user the speed of the IAutomobile
            Console.WriteLine($"The speed of the IAutomobile is {i.Speed}");

            // Compares the IAutomobile and the first Sedan objects together
            Console.WriteLine(s == i);

            // Calls the IncreaseSedanSpeed method
            s2.IncreaseSedanSpeed();

            // Compares the first Sedan and the second Sedan objects together
            Console.WriteLine(s == s2);

            // Creates an instance of the Truck class
            Truck t = new Truck(5, 100);

            // Calls the Stringify method on all of the objects
            s.Stringify();
            i.Stringify();
            s2.Stringify();
            t.Stringify();

        }
    }
}
