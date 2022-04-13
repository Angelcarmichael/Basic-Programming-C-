using System;

namespace HelloWorld_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Asks a question//
            Console.WriteLine("What is your first name?");
            //Allows the user to input imformation//
            string firstName = Console.ReadLine();
            //Asks a question//
            Console.WriteLine("What is your last name?");
            //Allows the user to input imformation//
            string lastName = Console.ReadLine();
            //Displace Hi and what the user entered//
            Console.WriteLine($"Hi {firstName} {lastName}");
        }
    }
}
