using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Carmichael_Nathan
{
    class Card
    {
        // A propertie named Number
        public char Number { get; }
        
        // A propertie named Suit 
        public string Suit { get; }

        // A constructor with two parameters
        public Card(char number, string suit)
        {
            Number = number;
            Suit = suit;
        }
    }
}
