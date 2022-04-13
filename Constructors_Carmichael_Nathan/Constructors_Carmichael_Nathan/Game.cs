using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_Carmichael_Nathan
{
    class Game
    {
        //Two public string fields
        public string title;
        public string genre;
        //Creates a class constructor
        public Game(string title = "Unknown Title", string genre = "Casual")
        {
            this.title = title;
            this.genre = genre;
        }
    }
}
