using System;

namespace Static_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the  user to enter a whole number
            Console.WriteLine($"Please enter a whole number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            //Asks the  user to enter anothor whole number
            Console.WriteLine($"Please enter anothor whole number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            //Calls the Add, Subtract, Multiply, and Divide methods 
            Calculate.Add(number1, number2);
            Calculate.Subtract(number1, number2);
            Calculate.Multiply(number1, number2);
            Calculate.Divide(number1, number2);

            //Asks the  user to enter a decimal number
            Console.WriteLine($"Please enter a decimal number");
            float float1 = Convert.ToSingle(Console.ReadLine());
            //Asks the  user to enter anothor decimal number
            Console.WriteLine($"Please enter a anothor decimal number");
            float float2 = Convert.ToSingle(Console.ReadLine());

            //Calls the Add, Subtract, Multiply, and Divide methods
            Calculate.Add(float1, float2);
            Calculate.Subtract(float1, float2);
            Calculate.Multiply(float1, float2);
            Calculate.Divide(float1, float2);

            //Tells the user the results for the whole numbers they enter, after the numbers have been Added, Subtracted, Multiplyed, and Divided together 
            Console.WriteLine($"{number1} + {number2} =");
            Console.WriteLine(Calculate.Add(number1, number2));
            Console.WriteLine($"{number1} - {number2} =");
            Console.WriteLine(Calculate.Subtract(number1, number2));
            Console.WriteLine($"{number1} * {number2} =");
            Console.WriteLine(Calculate.Multiply(number1, number2));
            Console.WriteLine($"{number1} / {number2} =");
            Console.WriteLine(Calculate.Divide(number1, number2));

            //Tells the user the results for the decimal numbers they enter, after the numbers been Added, Subtracted, Multiplyed, and Divided together
            Console.WriteLine($"{float1} + {float2} =");
            Console.WriteLine(Calculate.Add(float1, float2));
            Console.WriteLine($"{float1} - {float2} =");
            Console.WriteLine(Calculate.Subtract(float1, float2));
            Console.WriteLine($"{float1} * {float2} =");
            Console.WriteLine(Calculate.Multiply(float1, float2));
            Console.WriteLine($"{float1} / {float2} =");
            Console.WriteLine(Calculate.Divide(float1, float2));
        }
    }
}
