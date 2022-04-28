using System;
using System.IO;

namespace Enums_Carmichael_Nathan
{
    // A global enum called Months
    enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Three intgers variables
            int myBirthMonth = (int)Months.July;
            int myBirthDay = 11;
            int myBirthYear = 2003;

            // A string variables
            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}.";

            // Creates a file called "myFile.txt" ,and adds some text to it
            File.WriteAllText("myFile.txt", "When is your birthday?\n");

            // Reads the file created and print it to console
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            // Appends text to the file created ,and display all the text from the file to console
            File.AppendAllText("myFile.txt", "Are you ready for your birthday?\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            // Determines if a flie called "newFile.txt" and performs an action based on the result 
            if (!File.Exists("newFile.txt"))
            {
                // If "newFile.txt" does not exist ,"myFile.txt" is copyed to a new file called "newFile.txt"
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                // If "newFile.txt" does exist ,"myFile.txt" replaces the file with "myFile.txt"
                File.Replace("myFile.txt", "newFile.txt", "BackUpFile.txt");
            }

            // Appends the myBirthDate string to the new file ,and displays all the text from the file to console
            File.AppendAllText("newFile.txt", myBirthDate);
            Console.WriteLine(File.ReadAllText("newFile.txt"));
        }   
    }
}
