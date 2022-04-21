using System;

namespace Objects_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates an instance of the Computer class anf passes in three arguments 
            Computer c = new Computer("Dell", "Laptop", true);

            // Creates an instance of the IBootup interface
            IBootUp i = c;

            // Compares the first Computer and the IBootup objects, and tells the user the results
            Console.WriteLine(c == i);

            // Creates another instance of the Computer class anf passes in three arguments
            Computer c2 = new Computer("Mac", "PC", false);

            // Compares the first Computer and the Second Computer objects, and tells the user the results
            Console.WriteLine(c == c2);

            // A string variable, with the ToString method assigned to the first Computer object
            string p = c.ToString();

            // Compares the string variable and the first Computer object, and tells the user the results
            Console.WriteLine(p == c.ToString());

            // Compares the string variable and the IBootUp object, and tells the user the results
            Console.WriteLine(p == i.ToString());

            // Tells the user the type of the first Computer object
            Console.WriteLine(c.GetType());

            // Tells the user the type of the IBootUp object
            Console.WriteLine(i.GetType());

            // Calls the PowerOnOff method
            c.PowerOnOff();

            // Tells the if the string has i in it and where it is located 
            Console.WriteLine(p.IndexOf('i'));

            // Displays a message the user in all uppercase letters  
            Console.WriteLine(p.ToUpper());
        }
    }
}
