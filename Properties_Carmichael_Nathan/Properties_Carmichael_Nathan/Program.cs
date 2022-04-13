using System;

namespace Properties_Carmichael_Nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates an instance of the Car class
            Car c = new Car();
            //Assigns the Car object a model and make
            c.Model = "Ford";
            c.Make = "Mustang";
            //Display a message to the user 
            Console.WriteLine($"Nathan's favorite sports car is a");
            //Tells the user the car's Model
            Console.WriteLine(c.Model);
            //Tells the user the car's Make
            Console.WriteLine(c.Make);
            //Creates an instance of the Car class
            Car c2 = new Car();
            //Assigns the Car object a model and make
            c2.Model = "Chevrolet";
            c2.Make = "Camaro";
            //Display a message to the user
            Console.WriteLine($"Beth's favorite sports car is a");
            //Tells the user the car's Model
            Console.WriteLine(c2.Model);
            //Tells the user the car's Make
            Console.WriteLine(c2.Make);
        }
        
    }
}
