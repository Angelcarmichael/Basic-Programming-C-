using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Carmichael_Nathan
{
    class Game
    {
        // A property named Title with an automatic getter
        public string Title { get; }

        // A property named Esrb with an automatic getter
        public char Esrb { get; }

        // A property named Genre with an automatic getter
        public string Genre { get; }

        // A constructor with 3 parameters
        public Game(string title, char esrb, string genre)
        {
            Title = title;
            Esrb = esrb;
            Genre = genre;
        }
    }
}
