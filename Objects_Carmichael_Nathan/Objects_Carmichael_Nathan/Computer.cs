using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_Carmichael_Nathan
{
    class Computer : IBootUp
    {
        // An automatic property named Brand
        public string Brand { get; set; }

        // An automatic property named Type
        public string Type { get; set; }

        // An automatic property named IsOn
        public bool IsOn { get; set; }

        // A constructor that takes two string and one boolen parameters 
        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        } 

        // A method that determines if the Computer is on, and displays a message depending on the results
        public void PowerOnOff()
        {
            IsOn = !IsOn;

            if (IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The computer is shutting down!");
            }
        }

        // An override method that returns a string 
        public override string ToString()
        {
            return $"This computer is made by {Brand} and is a {Type} computer.";
        }
    }
}
