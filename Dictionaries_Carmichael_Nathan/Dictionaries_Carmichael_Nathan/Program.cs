using System;
using System.Collections.Generic;
using System.Collections;
namespace Dictionaries_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)  
        {
            // A Dictionary named topGames 
            Dictionary<int, string> topGames = new Dictionary<int, string>();

            // Adds 10 items to the Dictionary
            topGames.Add(1, "Pokemon Legends Arceus");
            topGames.Add(2, "Lego DC Super Villains");
            topGames.Add(3, "Legend of Zelda: Breath of the Wild");
            topGames.Add(4, "Lego Marvel Superheroes 2");
            topGames.Add(5, "Blazblue: Cross Tag Battle");
            topGames.Add(6, "Blue Reflection: Second Light");
            topGames.Add(7, "Dragon's Dogma: Dark Arisen");
            topGames.Add(8, "Shin Megami Tensei V");
            topGames.Add(9, "Monster Hunter Stories 2: Wings of Ruin");
            topGames.Add(10, "God Eater 3");

            // Loops through the topGames dictionary ,and prints out each Key/Value pair on a new line
            foreach (KeyValuePair<int, string> kvp in topGames)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            // Checks if topGames contains key 1, if it does, prints to console
            if (topGames.ContainsKey(1))
            {
                Console.WriteLine($"My favorite game is: {topGames[1]}");
            }

            // A string variable
            string result = null;

            // Implements the TryGetValue method on topGames for key 11, and set out to the result string
            topGames.TryGetValue(11, out result);

            // Checks if the result string's value has change, and preform an action depending on the result
            if (result != null)
            {
                // print the new result value to console
                Console.WriteLine(result);
            }
            else
            {
                // Displays a message to the console
                Console.WriteLine("There is no game in the eleventh position.");
            }

            // Switchs the dictionary entry object at key 5
            topGames[5] = "Persona 5";

            // Checks if topGames contains key 5, if it does, prints to console
            if (topGames.ContainsKey(5))
            {
                Console.WriteLine($"One of my favorite games is: {topGames[5]}");
            }

            // A Hashtable named games
            Hashtable games = new Hashtable(topGames);

            // Sets favGame equal to topGames
            string favGame = (string)games[1];

            // Prints each game to console
            Console.WriteLine($"My favorite game is: {favGame}");

            // A Hashtable named capitals
            var capitals = new Hashtable()
            {
                {"Arizona", "Phoenix"},
                {"Arkansas",  "Little Rock" },
                {"Oklahoma", "Oklahoma City" },
                {"Ohio", "Columbus"}
            };

            // Loops through the capitals hashtable, and prints out the DictionaryEntry objects key and value on a new line
            foreach (DictionaryEntry de in capitals)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            // Clears all elements in the capitals hashtable
            capitals.Clear();


        }

    }
}
