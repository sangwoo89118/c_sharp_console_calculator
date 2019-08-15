using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library
{
    public class Calculator
    {
        public static void Calculation(string userInput, out int output, out List<int> negativeNums, out List<int> validNums)
        {
            output = 0;
            negativeNums = new List<int>();
            validNums = new List<int>();

            List<string> delimiterString = new List<string>(new string[] { ",", "\\n", "\n" });

            // if user input custome delimiter
            if (userInput.IndexOf("//") == 0)
            {
                string customDelimiter = userInput.Substring(2, userInput.IndexOf("\\n") - 2);
                string[] customDelimiterArray = customDelimiter.Split(new string[] { "]" }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < customDelimiterArray.Count(); i++)
                {
                    //add it to delimiterString 
                    delimiterString.Add(customDelimiterArray[i].Replace("[", string.Empty));
                }

                userInput = userInput.Substring(userInput.IndexOf("\\n"));
            }


            // parse user input into an array of strings for each numbers  
            string[] numbers = userInput.Split(delimiterString.ToArray(), StringSplitOptions.RemoveEmptyEntries);     

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
                    // store 0 to valid numbers when number is greater than 1000
                    else if (num > 1000)
                    {
                        validNums.Add(0);
                        continue;
                    }

                    // store numbers to valid numbers
                    validNums.Add(num);
                    // add each number to output
                    output += num;
                }
                // if not a number
                else
                {
                    // store 0 to valid numbers 
                    validNums.Add(0);
                }
            }    
        }
    }
}
