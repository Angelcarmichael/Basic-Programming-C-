using System;
using System.Collections.Generic;
namespace Queues_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a Game object and set its max players to 50 and current players to 49
            Game g = new Game(50, 49);

            // Creates a Queue of Player objects
            Queue<Player> players = new Queue<Player>();

            // 4 Player objects with 100 health and a unique gamer tag
            Player p1 = new Player(100, "Mole Rock");
            Player p2 = new Player(100, "Down Walk");
            Player p3 = new Player(100, "Go Fall");
            Player p4 = new Player(100, "No Flat");

            // Calls JoinGame on all 4 player objects, and passes through the game and queue as arguments
            p1.JoinGame(g, players);
            p2.JoinGame(g, players);
            p3.JoinGame(g, players);
            p4.JoinGame(g, players);

            // Displays a message to the console
            Console.WriteLine("Players in Queue");

            // Loop through the queue and print all the players
            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }

            // Calls KickPlayer method on the game
            g.KickPlayer();

            // Calls CheckQueue method on the game
            g.CheckQueue(players);

            // Displays a message to the console
            Console.WriteLine("\nPlayers in Queue");

            // Loop through the queue and print all the players
            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
