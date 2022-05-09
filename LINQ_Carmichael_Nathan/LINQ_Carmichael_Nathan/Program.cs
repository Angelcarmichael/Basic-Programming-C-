using System;
using System.Linq;
using System.Collections.Generic;
namespace LINQ_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            // An array of Games called games with 10 games
            Game[] games = new Game[] {
                new Game("Minecraft" , 'E', "Action-Adventure"),
                new Game("Legend of Zelda: Breath of the Wild",'E',"Action-Adventure"),
                new Game("Blue Reflection: Second Light", 'T', "Role-Playing"),
                new Game("Blazblue: Cross Tag Battle", 'T', "Fighting"),
                new Game("Pokemon Legends: Arceus", 'E', "Adventure/Role-Playing"),
                new Game("Dragon's Dogma: Dark Arisen", 'M',"Action-Adventure"),
                new Game("Lego DC Super Villains", 'E', "Action-Adventure"),
                new Game("Persona 5", 'M', "Role-Playing"),
                new Game("Lego Marvel Superheroes 2", 'E', "Action-Adventure"),
                new Game("God Eater 3", 'T', "Action Role-Playing")
            };

            // A LINQ Query to get all games with less than 10 characters in the title
            var shortGames = from g in games
            where g.Title.Length < 10
            select($"Game Title: {g.Title.ToUpper()}");

            // Loops through shortGames and prints all games with less than 10 characters in the title to Console
            foreach (var game in shortGames)
            {
                Console.WriteLine(game);
            }

            // A LINQ method query that finds the game Minecraft from the games array
            var mineCraft = games.Where(g => g.Title.Contains("Minecraft"))
                                   .Select(g => $"Title: {g.Title}, ESRB: {g.Esrb}, Genre: {g.Genre}");

            // Prints all the game properties of mineCraft to console
            Console.WriteLine(mineCraft.FirstOrDefault());

            // A LINQ method query that finds all the titles with an esrb rating of T for teen
            var tRated = games
            .Where(g => g.Esrb.Equals('T'))
            .Select(g => g.Title);

            // Displays a message to console
            Console.WriteLine("T Rated Games:");

            // Loops through tRated and prints all games with an esrb rating of T for teen
            foreach (var game in tRated)
            {
                Console.WriteLine(game);
            }

            // A LINQ method query that finds all the titles with an esrb rating of E for everyone ,and a genre of Action
            var eRatedAction = games
            .Where(g => g.Esrb.Equals('E') && g.Genre.Contains("Action"))
            .Select(g => g.Title);

            // Displays a message to console
            Console.WriteLine("E Rated Action Games:");

            // Loops through tRated and prints all games with an esrb rating of E for everyone ,and a genre of Action
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }
        }
    }
}
