using System;

namespace Constructors_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displays a message to the user 
            Console.WriteLine($"Game 1's title and genre");
            //Creates an instance of the Game class
            Game g = new Game("LEGO DC Super-Villains", "Action-adventure platform");
            //Tells the user the game's title 
            Console.WriteLine(g.title);
            //Tells the user the game's genre 
            Console.WriteLine(g.genre);
            //Displays a message to the user
            Console.WriteLine($"Game 2's title and genre");
            //Creates an instance of the Game class
            Game g2 = new Game();
            //Tells the user the game's title
            Console.WriteLine(g2.title);
            //Tells the user the game's genre
            Console.WriteLine(g2.genre);
        }
    }
}
