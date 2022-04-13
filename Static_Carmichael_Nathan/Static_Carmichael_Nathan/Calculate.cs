using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Carmichael_Nathan
{
    //Creates a static class
    static class Calculate
    {
        //A public static float
        public static float result;

        //A static constructor that initializes the result value to '0.0f
        static Calculate()
        {
            result = 0.0f;
        }

        //A method that Adds two whole numbers  
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        //A method that Subtracts two whole numbers
        public static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
        //A method that Multiplys two whole numbers
        public static int Multiply(int number1, int number2)
        {
            return number1 * number2; 
        }
        //A method that Divides two whole numbers
        public static int Divide(int number1, int number2)
        {
            return number1 / number2;
        }

        //A method that Adds two decimal numbers
        public static float Add(float float1, float float2)
        {
            return float1 + float2;
        }
        //A method that Subtracts two decimal numbers
        public static float Subtract(float float1, float float2)
        {
            return float1 - float2;
        }
        //A method that Multiplys two decimal numbers
        public static float Multiply(float float1, float float2)
        {
            return float1 * float2;
        }
        //A method that Divides two decimal numbers
        public static float Divide(float float1, float float2)
        {
            return float1 / float2;
        }
    }
}
