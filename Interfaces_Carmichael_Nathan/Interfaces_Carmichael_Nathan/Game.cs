using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Carmichael_Nathan
{
     class Game : IGenre 
     {
        //An automatic property named ESRB
        public string ESRB
        { get; }

        //An automatic property named Genre
        public string Genre
        { get; }

        //An automatic property named Title
        public string Title
        { get; }

        //A constructor that takes three string parameters
        public Game(string genre, string esrb, string title)
        {
            ESRB = esrb;
            Genre = genre;
            Title = title;
        }

        //A method that displays a message to the console
        public void PlayGame()
        {
            Console.WriteLine($"Game is Starting");
        }

        //A method that returns a string that describes the game and includes the title and esrb ,and displays it to the console
        public string Describe()
        {
            return $"Let's play a fun {Genre} game called {Title} with a rating of {ESRB}";

        }
     }   
}
