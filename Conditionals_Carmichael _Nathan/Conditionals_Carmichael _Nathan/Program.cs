using System;

namespace Conditionals_Carmichael__Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user to enter a whole number 
            Console.WriteLine("Please enter a whole number");
            int myintger = Convert.ToInt32(Console.ReadLine());
            //Preforms different actions depending number they chose 
            if (myintger >= 0)
            {
                // execute if the number is positive 
                Console.WriteLine($"{myintger} is positive");
            }
            else
            {
                // execute if the number is negative
                Console.WriteLine($"{myintger} is negative");
            }
            //Preforms different actions depending number they chose
            if (myintger % 2 == 0)
            {
                // execute if the number is even
                Console.WriteLine($"{myintger} is even");
            }
            else
            {
                // execute if the number is odd
                Console.WriteLine($"{myintger} is odd");
            }
            //Two random intgers
            int number1 = 6;
            int number2 = 8;
            //Finds the max between the first number and the first random intger  
            int first = Math.Max(myintger, number1);
            //Finds the max between the int first and the second random intger
            int second = Math.Max(first, number2);
            //Prints the largest number
            Console.WriteLine($"The largest number is {second}");
            //Asks the user to enter a grade 
            Console.WriteLine("Please enter a grade");
            Char grade = Console.ReadKey().KeyChar;
            //Preforms different actions depending the grade they chose
            switch (grade)
            {
                // execute if they entered A
                case 'A':
                    Console.WriteLine(" Superior");
                    break;
                // execute if they entered B
                case 'B':
                    Console.WriteLine(" Very Good");
                    break;
                // execute if they entered C
                case 'C':
                    Console.WriteLine(" Average");
                    break;
                // execute if they entered D
                case 'D':
                    Console.WriteLine(" Below Average");
                    break;
                // execute if they entered F
                case 'F':
                    Console.WriteLine(" Fail");
                    break;
                // execute if they entered a letter that is not a grade
                default:
                    Console.WriteLine(" Is not a grade");
                    break;
            }
        }
    }
}
