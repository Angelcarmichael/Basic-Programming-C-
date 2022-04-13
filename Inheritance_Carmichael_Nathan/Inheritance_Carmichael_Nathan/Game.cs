using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Carmichael_Nathan
{
    abstract class Game
    {
        //An automatic property named ESRB
        public string ESRB
        { get; set; }

        //An automatic property named Title
        public string Title
        { get; set; }

        //A constructor that takes two string parameters
        public Game(string esrb, string title)
        {
            ESRB = esrb;
            Title = title;
        }

        //A method that displays a message to the console
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting");
        }

        //Declares an abstract method 
        public abstract string Describe();
        
    }
}
