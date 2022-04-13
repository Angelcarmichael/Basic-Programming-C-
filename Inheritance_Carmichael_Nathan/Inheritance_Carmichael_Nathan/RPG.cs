using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Carmichael_Nathan
{
    class RPG : Game
    {
        //A constructor that takes two string parameters ,and inherits them from the base class
        public RPG(string esrb, string title) : base(esrb, title) 
        {
            ESRB = esrb;
            Title = title;
        }

        //A method that returns a string that describes the game and includes the title and esrb ,and displays it to the console
        public override string Describe()
        {
            return $"There is a fun game called {Title} and it's rating is {ESRB}";
        }
    }
}
