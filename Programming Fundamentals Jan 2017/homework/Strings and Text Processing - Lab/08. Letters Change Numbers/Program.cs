namespace _08.Letters_Change_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class LettersChangeNumbers
    {
        public static void Main(string[] args)
        {
            char[] ignore = new char[] { ' ', '\t'};
            string[] input = Console.ReadLine().Split(ignore, StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<decimal> results = new List<decimal>();
            foreach (string str in input)
            {
                var firstLetterRegex = Regex.Match(str, @"[A-Za-z]");
                var lastLetterRegex = Regex.Match(str, @"[A-Za-z]$");
                var numberRegex = Regex.Match(str, @"\d+");

                string firstLetterString = Convert.ToString(firstLetterRegex.ToString());
                string lastLetterString = Convert.ToString(lastLetterRegex.ToString());

                char firstLetter = firstLetterString[0];
                char lastLetter = lastLetterString[0];
                decimal number = Convert.ToDecimal(numberRegex.ToString());

                if (firstLetterString == firstLetterString.ToUpper())
                {
                    decimal firstLetterPosition = Convert.ToInt32(firstLetter) - 64;
                    number = number / firstLetterPosition;
                }
                else if (firstLetterString == firstLetterString.ToLower())
                {
                    decimal firstLetterPosition = Convert.ToInt32(firstLetter) - 96;
                    number = number * firstLetterPosition;
                }

                if (lastLetterString == lastLetterString.ToUpper())
                {
                    decimal lastLetterPostion = Convert.ToInt32(lastLetter) - 64;
                    number = number - lastLetterPostion;
                }
                else if (lastLetterString == lastLetterString.ToLower())
                {

                    decimal lastLetterPosition = Convert.ToInt32(lastLetter) - 96;
                    number = number + lastLetterPosition;
                }

                results.Add(number);
            }

            decimal result = results.Sum();

            Console.WriteLine($"{result:F2}");
        }
    }
}