using System;
using System.Collections.Generic;
using System.Text;

namespace Queues_Carmichael_Nathan
{
    class Player
    {
        // An property called Health with an automatic getter and setter
        public int Health { get; set; }

        // A property called GamerTag with an automatic getter
        public string GamerTag { get; }

        // A constructor that takes one int parameter and one string parameter
        public Player(int health, string gamertag)
        {
            Health = health;
            GamerTag = gamertag;
        }

        // A method called JoinGame that takes two parameters, and checks if the game's current players is equal to the max players
        public void JoinGame(Game game, Queue<Player> players)
        {
           if (game.CurrentPlayers == game.MaxPlayers)
           {
                // Adds 'this' player to the queue
                players.Enqueue(this);
           }
           else
           {
                // Displays a message to the console
                Console.WriteLine("Joining Game");

                // Increase current players by 1
                game.CurrentPlayers += 1;
           }
        }

        // An Override the ToString method that return  GamerTag
        public override string ToString()
        {
            return GamerTag;
        }
    }
}
