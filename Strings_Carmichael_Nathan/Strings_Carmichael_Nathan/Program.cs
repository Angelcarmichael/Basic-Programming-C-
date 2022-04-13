using System;

namespace Strings_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user to enter a letter
            Console.WriteLine("Please enter a letter");
            //Assigns the users input to a character 
            char myChar = Console.ReadKey().KeyChar;
            bool isLetter = Char.IsLetter(myChar);
            //Tell the user if what they entered is a letter
            Console.WriteLine($"\n {myChar} is a letter {isLetter}.");

            //Asks the user to enter some text
            Console.WriteLine("Please enter some text");
            string words = Console.ReadLine();
            //Asks the user to enter a word
            Console.WriteLine("Please enter a word");
            string word = Console.ReadLine();
            //Tells the user if the word they entered is in the text
            bool results = words.Contains(word);
            Console.WriteLine($"{word} exists in {words}, {results}.");
        }
    }
}
