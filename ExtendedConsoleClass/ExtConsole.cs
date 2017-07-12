using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendedConsoleClass
{
    class ExtConsole
    {
        private static string userInput;
        private static int parsedNum;
        private static double parsedDub;

        // will parse a string for a double
        public static int ParseInputInt(string someString)
        {
            int.TryParse(someString, out parsedNum);
            return parsedNum;
        }

        // will prompt an input from the user and parse it for an int
        public static int ParseInputInt()
        {
            userInput = Console.ReadLine();
            int.TryParse(userInput, out parsedNum);
            return parsedNum;
        }

        // will parse a string for a double
        public static double ParseInputDouble(string someString)
        {
            double.TryParse(someString, out parsedDub);
            return parsedDub;
        }

        // will prompt an input from the user and parse it for an double
        public static double ParseInputDouble()
        {
            userInput = Console.ReadLine();
            double.TryParse(userInput, out parsedDub);
            return parsedDub;
        }

        //will take a string, print it to the console, and request input from the user and return the input
        public static string RequestRecieve(string someText)
        {
            Console.WriteLine(someText);
            userInput = Console.ReadLine();
            Console.Clear();
            return userInput;
        }

        //Will take a string and print it to the console. Will recieve user input and validate it.
        //if the validation fails it will reprompt the user
        public static int RequestRecieveInt(string someText, string inputValidationMessage)
        {
            while (true)
            {
                Console.WriteLine(someText);
                userInput = Console.ReadLine();
                Console.Clear();
                if (int.TryParse(userInput, out parsedNum) == false)
                {
                    Console.WriteLine(inputValidationMessage);
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.Clear();
            return parsedNum;
        }
    }
}

