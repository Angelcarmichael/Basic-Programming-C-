using System;

namespace Casting_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user a question//
            Console.WriteLine("What is your favorite number?");
            //The user input//
            int favoriteNumber = Convert.ToInt32(Console.ReadLine());
            //Displaying the users response//
            Console.WriteLine($"WOW,Your favorite number is {favoriteNumber}!");
            //Asks the user a question//
            Console.WriteLine("So do you like video games? must put true or false");
            //The user input//
            bool isTrue = Convert.ToBoolean(Console.ReadLine());
            //Displaying the users response//
            Console.WriteLine($"It is {isTrue} that I like video games!");
        }
    }
}
