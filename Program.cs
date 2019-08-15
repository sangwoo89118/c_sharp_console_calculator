using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_console_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requirement #1 - implementation

            /// decalre variables
            // string - user input
            string userInput = string.Empty;
            // int - output
            int output = 0;

            // display welcome message
            Console.WriteLine("C# Console Application by Sangwoo Kim\n");

            // display instruction
            Console.WriteLine("This calculator only supports an Add operation given a signle formatted string");
            Console.WriteLine("Supports a maximum of 2 numbers");
            Console.WriteLine("Use a comma delimited format e.g. \"1,20\" will return 21");
            Console.WriteLine("Invalid/Missing numbers should be converted to 0 e.g. \"\" will return 0; \"5,tytyt\" will return 5\n\n");

            // store user input
            Console.WriteLine("Please enter 2 numbers with comma e.g. 1,20\n");
            userInput = Console.ReadLine();

            // parse user input into an array of strings for each numbers
            string[] numbers = userInput.Split(',');

            // loop thru array of strings 
            for (int i = 0; i < numbers.Count(); i++)
            {
                int num = 0;
                // validate the number, skip if it's not a number
                if (int.TryParse(numbers[i], out num))
                {
                    // add each number to output
                    output += num;
                }

            }

            // display output
            Console.WriteLine("Result is " + output);

            // press any key to exit
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
