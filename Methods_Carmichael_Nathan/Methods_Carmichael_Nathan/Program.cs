using System;

namespace Methods_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two random intgers 
            int number1 = 2;
            int number2 = 6;

            //Calls MyMethod and prints results to console
            Console.WriteLine(MyMethod(number1, number2));
            //Asks the user to enter a name
            Console.WriteLine($"Please enter a name");
            //A string variable for NewMethod
            string username = Console.ReadLine();
            //Calls NewMethod
            NewMethod(username);
            //Calls DayMethod
            DayMothod();
        }
        //A method that multiples two numbers
        public static int MyMethod(int number1, int number2) {
            return number1 * number2;
        }
        //A mothod that asks the user to enter a name and then displays a message 
        public static void NewMethod(string username)
        {
            //Displays a message
            Console.WriteLine($"Hello, {username}! It is nice to meet you!");
        }
        //A method that displays a message
        public static void DayMothod()
        {
            //Displays a message
            Console.WriteLine("Have a fantasic day");

        }

    }
}

