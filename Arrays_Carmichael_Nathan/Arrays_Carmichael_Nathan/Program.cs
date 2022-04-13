using System;

namespace Arrays_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user to enter enter the numbers elements
            Console.WriteLine($"Please enter numbers elements");
            int numbers = Convert.ToInt32(Console.ReadLine());
            //Makes an int array 
            int[] intarray = new int[numbers];
            //integers for the first foreach loop
            int sum = 0;
            int index = 0;
            //Loops through the numbers to find the sum
            foreach (int number in intarray)
            {
                //Asks the user to enter a number
                Console.WriteLine($"Please enter a number");
                intarray [index] = Convert.ToInt32(Console.ReadLine());
                sum += intarray [index];
                index++;
            }
            //Tells the user the sum of the numbers they entered 
            Console.WriteLine($"The sum is {sum}");
            //Sorts the numbrs in numerical order
            Array.Sort(intarray);
            //Tells the user the numerical order of the numbers
            Console.WriteLine($"The numerical order of the numbers is");
            //Loops through the numbers to find the numerical order of the numbers
            foreach (int number in intarray)
            {
                //Tells the user the numerical order of the numbers
                Console.WriteLine(number);
            }
                 
                   
        }
    }
}
