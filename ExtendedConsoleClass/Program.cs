using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedConsoleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstrations



            //will return 10
            string number = "5";
            int newNumber = ExtConsole.ParseInputInt(number);
            Console.WriteLine(newNumber + 5);

            //will return 7.5
            double newDouble = ExtConsole.ParseInputDouble(number);
            Console.WriteLine(newDouble + 2.5);

            // Will return the users name.
            string message = "Enter your name: ";
            string userName = ExtConsole.RequestRecieve(message);
            Console.WriteLine(userName);

            //Will return user input + 5 and do input validation
            message = "Enter a number: ";
            string validationMessage = "You must enter a whole number!";
            newNumber = ExtConsole.RequestRecieveInt(message, validationMessage);
            Console.WriteLine(newNumber + 5);

        }
    }
}