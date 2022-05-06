using System;
using System.Collections.Generic;
namespace Stacks_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            // A Card array with Card objects
            Card[] cards = new Card[] {
                new Card('A', "Harts"),
                new Card('K', "Harts"),
                new Card('Q', "Harts"),
                new Card('A', "Diamonds"),
                new Card('Q', "Diamonds"),
                new Card('K', "Diamonds"),
                new Card('8', "Diamonds"),
                new Card('4', "Diamonds"),
                new Card('6', "Harts")
            };

            // Creates a Card stack called startingDeck, and pushs the cards from the Card array
            Stack<Card> startingDeck = new Stack<Card>(cards);

            // Displays a message to the console
            Console.WriteLine("Cards in the deck:");

            // Loops through the stack, and print out each card
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

            // Prints to console the number of cards in the stack
            Console.WriteLine(startingDeck.Count);

            // A list named myHand, and contans 3 different Cards
            List<Card> myHand = new List<Card>() { new Card('j', "Diamonds"), new Card('3', "Clubs"), new Card('5', "Clubs") };

            // Displays a message to the console
            Console.WriteLine("Got any 8's?");

            // Trys to Add a card to myHand from the stack by popping it
            if (startingDeck.Count > 0)
            {
                myHand.Add(startingDeck.Pop());
            }

            // Prints to console the number of cards in the stack
            Console.WriteLine(startingDeck.Count);

            // Places one of the cards in myNand on the startingDeck stack
            startingDeck.Push(myHand[2]);

            // Delete the card placed from myHand
            myHand.Remove(myHand[2]);

            // Displays a message to the console
            Console.WriteLine("Cards in the deck:");

            // Loops through the stack, and print out each card
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }
        }
    }
}
