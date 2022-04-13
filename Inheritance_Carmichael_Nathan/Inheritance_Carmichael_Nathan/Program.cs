using System;

namespace Inheritance_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates an instance of the RPG class ,and passes through two arguments
            RPG r = new RPG("E for Everyone", "Pokemon Legends Arceus");

            //Calls the Describe method ,and displays a message to the console
            Console.WriteLine(r.Describe());

            //Calls the PlayGame method
            r.PlayGame();
        }
    }
}
