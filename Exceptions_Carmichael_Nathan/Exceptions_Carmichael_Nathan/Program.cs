using System;

namespace Exceptions_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three float variables
            float number1 = 6;
            float number2 = 0;
            float result = 0;

            // A random object 
            Random r = new Random();

            // A initialized int with a random range from 2 to 30
            int num = r.Next(2, 30);

            /* A try statement that trys to assign result to the Divide method
            and passes in the first two float variables as arguments*/
            try
            {
                result = Divide(number1, number2);
            }
            /* A catch statement that displays an error message tellig the user there is an error, 
             and asks the user to enter a number*/ 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please input a floating point number other than zero");

                /* A try statement that trys to assign result to the Divide method 
                 and passes in the first float variable and the number the user inputed*/
                try
                {
                    result = Divide(number1, (float)Convert.ToDouble(Console.ReadLine()));
                }
                // A catch statement that displays an error message tellig the user there is an error
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                }
            }
            // A finally statement that execute the code displays a message
            finally
            {
                Console.WriteLine($"Calculations completed, with result of {result}!");
            }

            // A try statement that calls the CheckAge method
            try
            {
                CheckAge(num);
            }
            /* A catch statement that displays an error message tellig the user there is an error, 
             and asks the user to enter a different age*/
            catch
            {
                Console.WriteLine("Please enter a different age");
            }
        }

        // A method that determines if the second parameter is equal to zero
        public static float Divide(float number1, float number2)
        {
            if (number2 == 0)
            {
                throw new DivideByZeroException();
            }
            else
            { 
                return (number1 / number2);
            }
        }

        /* A method that determines if age is greater than or equal to 17 
         ,and displays a message depending on the result*/
        public static void CheckAge(int age)
        {
            if (age >= 17)
            {
                Console.WriteLine($"You are {age}, you can play mature games!");
            }
            else
            {
                throw new ArgumentException();
            }

        }
    }
}
