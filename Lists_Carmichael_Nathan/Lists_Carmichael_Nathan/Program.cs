using System;
using System.Collections.Generic;

namespace Lists_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            // A intger variable
            int numofgames = 6;

            // A List named games, with three arguments
            List<string> games = new List<string> { "Legend of Zelda Breath of The Wild", "Pokemon Legends Arceus", "Blue Reflection Second Light" };

            // An Array named otherGames, with three arguments
            string[] otherGames = new string[] { "Dragon's Dogma Dark Arisen", "Assassin's Creed black Flag", "God Eater 3" };

            // A foreach loop that prints each game in the games list
            foreach (string game in games)
            {
                // Prints each game to console
                Console.WriteLine(game);
            }
            // Prints to console the number of items in the list
            Console.WriteLine(games.Count);

            // Adds a range to the list using the otherGames array
            games.AddRange(otherGames);

            // Print to console the number of items in the list
            Console.WriteLine(games.Count);

            // Checks if Halo is in the games list, and preform an action depending on the result
            if (games.Contains("Halo"))
            {
                // Displays a message to the console
                Console.WriteLine("MASTER CHIEF is in the house!");
            }
            else
            {
                // Adds Halo to the games list
                games.Add("Halo");
            }

            // Checks if numofgames is less than the number of games in the games list, and preform an action depending on the result
            if (numofgames < games.Count)
            {
                // Removes the game at index 6 of the games list
                games.RemoveAt(6);
            }
            else
            {
                // Displays a message to the console
                Console.WriteLine("Game not found!");
            }
            Console.WriteLine("All games in the list:");

            // A foreach loop that prints each game in the games list
            foreach (string game in games)
            {
                // Prints each game to console
                Console.WriteLine(game);
            }

            // Sorts the games list
            games.Sort();

            // Displays a message to the console
            Console.WriteLine("Sorted Games List:");

            // A foreach loop that prints each game in the games list
            foreach (string game in games)
            {
                // Prints each game to console
                Console.WriteLine(game);
            }

            // An Array named newList, with six arguments
            string[] newList = new string[6];

            // Copys the games list to the array newList
            games.CopyTo(newList);

            // Clears the games list
            games.Clear();

            // Displays a message to the console
            Console.WriteLine("New Games List:");

            // A foreach loop that prints each game in the games list
            foreach (string game in newList)
            {
                // Prints each game to console
                Console.WriteLine(game);
            }
        }

        
    }
}
