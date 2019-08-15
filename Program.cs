using System;
using System.Collections.Generic;

namespace c_sharp_console_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stretch goal #2 - implementation

            /// decalre variables
            // string - user input
            string userInput = string.Empty;
            // int - output
            int output = 0;
            // int[] - negative numbers 
            List<int> negativeNums = new List<int>();
            // string[] - valid numbers                                                  
            List<int> validNums = new List<int>();

            // display welcome message
            Console.WriteLine("C# Console Application by Sangwoo Kim\n");

            // display instruction
            Console.WriteLine("This calculator only supports an Add operation given a signle formatted string");
            Console.WriteLine("Supports more than 2 numbers");
            Console.WriteLine("Supports a newline character as an alternative delimiter e.g. \"1\\n2,3\" will return 6");
            Console.WriteLine("Invalid/Missing numbers should be converted to 0 e.g. \"\" will return 0; \"5,tytyt\" will return 5");
            Console.WriteLine("Deny negative numbers. An exception will be thrown that includes all of the negative numbers provided");
            Console.WriteLine("Ignore any number greater than 1000 e.g. \"2,1001,6\" will return 8");
            Console.WriteLine("Support multiple any delimiter");
            Console.WriteLine("\tuse the format: \"{number},{number}\" e.g. \"1,20\"");
            Console.WriteLine("\tuse the format: \"//{delimiter}\\n{numbers}\" e.g. \"//;\\n2;5\" will return 7");
            Console.WriteLine("\tuse the format: \"//[{delimiter}]\\n{numbers}\" e.g. \"//[***]\\n11***22***33\" will return 66");
            Console.WriteLine("\tuse the format: \"//[{delimiter}][{delimiter}]\\n{numbers}\" e.g. \"//[*][!!][rrr]\\n11rrr22*33!!44\" will return 110");
            Console.WriteLine("\n\n");

            // store user input
            Console.WriteLine("Please enter numbers with comma or custome delimiter as shown in instruction above");
            userInput = Console.ReadLine();

            Calculator.Library.Calculator.Calculation(userInput, out output, out negativeNums, out validNums);

            // deny negative numbers
            if (negativeNums.Count < 0)
            {
                Console.WriteLine("Negative numbers are not supported [{0}]", string.Join(",", negativeNums));
            }
            else
            {
                // display output
                Console.WriteLine("\n");
                Console.WriteLine(string.Join("+", validNums) + " = " + output);
            }

            // press any key to exit
            Console.WriteLine("\n");
            Console.WriteLine("Press ESC to exit");

            while (true)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
