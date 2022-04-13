using System;

namespace Interfaces_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates an instance of the Game class ,and passes through three arguments
            Game g = new Game("Open Word", "E10+ Everyone 10+","The Legend of Zelda Breath of the Wild");
            
            //Calls the Describe method ,and displays a message to the console
            Console.WriteLine(g.Describe());

            //Calls the PlayGame method
            g.PlayGame();

            //Creates an instance of the Movie class ,and passes through three arguments
            Movie m = new Movie("Sperhero", "PG-13", "Justice League");
            
            //Calls the Describe method ,and displays a message to the console
            Console.WriteLine(m.Describe());

            //Calls the PlayMovie method
            m.PlayMovie();
        }
    }
}
