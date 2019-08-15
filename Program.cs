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
            // Requirement #3 - implementation

            /// decalre variables
            // string - user input
            string userInput = string.Empty;
            // int - output
            int output = 0;

            // display welcome message
            Console.WriteLine("C# Console Application by Sangwoo Kim\n");

            // display instruction
            Console.WriteLine("This calculator only supports an Add operation given a signle formatted string");
            Console.WriteLine("Supports more than 2 numbers");
            Console.WriteLine("Use a comma delimited format e.g. \"1,20\" will return 21");
            Console.WriteLine("Supports a newline character as an alternative delimiter e.g. \"1\\n2,3\" will return 6");
            Console.WriteLine("Invalid/Missing numbers should be converted to 0 e.g. \"\" will return 0; \"5,tytyt\" will return 5");
            Console.WriteLine("Deny negative numbers. An exception will be thrown that includes all of the negative numbers provided");
            Console.WriteLine("Ignore any number greater than 1000 e.g. \"2,1001,6\" will return 8");
            Console.WriteLine("Support a single custom delimiter");
            Console.WriteLine("\tuse the format: \"//{delimiter}\\n{numbers}\" e.g. \"//;\\n2;5\" will return 7\n\n");


            // store user input
            Console.WriteLine("Please enter numbers with comma e.g. 1,20 or a single custom delimiter e.g. //;\\n2;5\n");
            userInput = Console.ReadLine();
                                     
            List<string> delimiterString = new List<string>(new string[] { ",", "\\n", "\n" });

            // if user input custome delimiter
            if (userInput.IndexOf("//") == 0)
            {
                //add it to delimiterString
                delimiterString.Add(userInput[2].ToString()); 
            }

            // parse user input into an array of strings for each numbers  
            string[] numbers = userInput.Split(delimiterString.ToArray(), StringSplitOptions.None);

            // int[] - negative numbers 
            List<int> negativeNums = new List<int>();

            // loop thru array of strings 
            for (int i = 0; i < numbers.Count(); i++)
            {
                int num = 0;
                // validate the number, skip if it's not a number
                if (int.TryParse(numbers[i], out num))
                {
                    // store all negative numbers
                    if (num < 0)
                    {
                        negativeNums.Add(num);
                    }
                    // ignore any number greater than 1000
                    else if (num > 1000)
                    {
                        continue;
                    }
                    // add each number to output
                    output += num;
                }
            }

            // deny negative numbers
            if (negativeNums.Count() > 0)
            {
                Console.WriteLine("Negative numbers are not supported [{0}]", string.Join(",", negativeNums));
            }
            else
            {
                // display output
                Console.WriteLine("Result is " + output);
            }

            // press any key to exit
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
