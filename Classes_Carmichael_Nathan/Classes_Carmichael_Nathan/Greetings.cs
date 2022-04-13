using System;

namespace Classes_Carmichael_Nathan
{
    class Greetings
    {
        //A method that welcomes the user
        public void Welcome()
        {
            //Displays a message thet welcomes the user
            Console.WriteLine($"Hello, who are you?");
        }
        //A method that greets and thanks the user 
        public void Hello(string name)
        {
            //Displays a message thet greets and thanks the user
            Console.WriteLine($"{name}, thank you for joining us today!");
        }
    }
}
