using System;

namespace Loops_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user to enter a sentence 
            Console.WriteLine($"Please enter a sentence");
            string sentence = Console.ReadLine();
            //Calls the spaces method
            spaces(sentence);
            //Asks the user to enter a number
            Console.WriteLine($"Please enter a number");
            string number = Console.ReadLine();
            //Calls the Numbersum method
            Numbersum(number);
        }
        //A method to fined the number spaces in the sentence the user entered 
        public static void spaces(string sentence)
        {
            int numberOfSpaces = 0;
            //Loops though the sentence the user entered to fined the number spaces in the sentence  
            foreach (char charater in sentence) {
                if (charater == ' ')
                    numberOfSpaces++;
            }
            {
                //Tells the user the number of spaces in the sentence the user entered
                Console.WriteLine($"{sentence} has {numberOfSpaces} spaces");
            }

        }
        //A method to fined the sum of the individual digits of a given number and returns the sum
        public static int Numbersum(string number)
        {
            int sum = 0;
            //Loops though the number the user entered to fined the sum of the individual digits
            foreach (char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }
            //Tells the user the sum of the number they entered 
            Console.WriteLine($"The sum of {number} is {sum}");
            return sum;
        }
    }
}
