using System;

namespace Classes_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates an instance of the Greetings class
            Greetings g = new Greetings();
            //Calls the Welcome method
            g.Welcome(); 
            //Asks the user to enter a name 
            Console.WriteLine($"Please enter a name");
            string name = Console.ReadLine();
            //Calla the Hello method
            g.Hello(name);
        }
    }
       
}
