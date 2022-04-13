using System;

namespace Operators_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates Int variables and gives them values 
            int lifes = 2 / 10;
            int deaths = 2 + 4;
            //Finds the max & min of the variables
            Console.WriteLine("The min of " + lifes + " and " + deaths + " is " + Math.Min(lifes, deaths));
            Console.WriteLine("The max of " + lifes + " and " + deaths + " is " + Math.Max(lifes, deaths));
            //Makes a a boolean and displaying the a statment with the variables 
            bool isIntGreaater = (lifes > deaths);
            Console.WriteLine(lifes + " are greater than " + deaths + "," + isIntGreaater);
            
            //Creates short variables and gives them values 
            short falls = 2 / 10;
            short jumps = 2 + 4;
            //Finds the max & min of the variables
            Console.WriteLine("The min of " + falls + " and " + jumps + " is " + Math.Min(falls, jumps));
            Console.WriteLine("The max of " + falls + " and " + jumps + " is " + Math.Max(falls, jumps));
            //Makies a a boolean and displaying the a statment with the variables 
            bool isshortGreaater = (falls > jumps);
            Console.WriteLine(falls + " are greater than " + jumps + "," + isshortGreaater);
            
            //Creates long variables and gives them values 
            long wins = 2 / 10;
            long fails = 2 + 4;
            //Finds the max & min of the variables
            Console.WriteLine("The min of " + wins + " and " + fails + " is " + Math.Min(wins, fails));
            Console.WriteLine("The max of " + wins + " and " + fails + " is " + Math.Max(wins, fails));
            //Makes a a boolean and displaying the a statment with the variables
            bool islongGreaater = (wins > fails);
            Console.WriteLine(wins + " are greater than " + fails + "," + islongGreaater);

            //Creates float variables and gives them values
            float forward = 2 / 10;
            float stops = 2 + 4;
            //Finds the max & min of the variables
            Console.WriteLine("The min of " + forward + " and " + stops + " is " + Math.Min(forward, stops));
            Console.WriteLine("The max of " + forward + " and " + stops + " is " + Math.Max(forward, stops));
            //Makes a a boolean and displaying the a statment with the variables
            bool isfloatGreaater = (forward > stops);
            Console.WriteLine(forward + " are greater than " + stops + "," + isfloatGreaater);

            //Creates double variables and gives them values
            double beginning = 2 / 10;
            double ends = 2 + 4;
            //Finds the max & min of the variables
            Console.WriteLine("The min of " + beginning + " and " + ends + " is " + Math.Min(beginning, ends));
            Console.WriteLine("The max of " + beginning + " and " + ends + " is " + Math.Max(beginning, ends));
            //Makes a a boolean and displaying the a statment with the variables
            bool isdoubleGreaater = (beginning > ends);
            Console.WriteLine(beginning + " are greater than " + ends + "," + isdoubleGreaater);

            //Creates Decimal variables and gives them values
            Decimal good = 2 / 10;
            Decimal bad = 2 + 4;
            //Finds the max & min of the variables
            Console.WriteLine("The min of " + good + " and " + bad + " is " + Math.Min(good, bad));
            Console.WriteLine("The max of " + good + " and " + bad + " is " + Math.Max(good, bad));
            //Makes a a boolean and displaying the a statment with the variables
            bool isDecimalGreaater = (good > bad);
            Console.WriteLine(good + " are greater than " + bad + "," + isDecimalGreaater);
        }
    }
}
