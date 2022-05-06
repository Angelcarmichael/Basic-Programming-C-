using System;
using System.Collections.Generic;
using System.Text;

namespace Queues_Carmichael_Nathan
{
    class Game
    {
        // A property called MaxPlayers with an automatic getter
        public int MaxPlayers { get; }

        // A property called CurrentPlayers with an automatic getter and setter
        public int CurrentPlayers { get; set; }

        //  A constructor that takes two int parameters
        public Game(int maxPlayers, int currentPlayers)
        {
            MaxPlayers = maxPlayers;
            CurrentPlayers = currentPlayers;
        }

        // A method called KickPlayer that decrement CurrentPlayers by 1
        public void KickPlayer()
        {
            CurrentPlayers -= 1;
        }

        // A method called CheckQueue, that takes a Queue<Player> parameter   
        public void CheckQueue(Queue<Player> players)
        {
            //  Checks  CurrentPlayers is less than MaxPlayers
            if (CurrentPlayers < MaxPlayers)
            {
                // Checks if the queue has elements in it
                if (players.Count > 0) 
                {
                    // If the queue has players in it, calls Dequeue method on the queue and increment current players by 1
                    if (players.Count > 0)
                    {
                        players.Dequeue();

                        CurrentPlayers -= 1;
                    }
                    else
                    {
                        // Displays a message to the console
                        Console.WriteLine("No Players in the Queue!");
                    }
                }
            }

            
        }
    }
}
