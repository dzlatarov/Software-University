using System;
using System.Linq;
using System.Text;

public static class LettersChangeNumbers
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        double totalSum = 0;

        bool wasLower = false;
        foreach (var magicNumber in input)
        {
            wasLower = false;

            StringBuilder numberString = new StringBuilder();

            foreach (var c in magicNumber)
            {
                if (char.IsDigit(c))
                {
                    numberString.Append(c);
                }
            }

            char firstLetter = magicNumber[0];
            char lastLetter = magicNumber.Last();
            double number = double.Parse(numberString.ToString());

            if (char.IsUpper(firstLetter))
            {
                number = number / (firstLetter - 64);
            }
            else if (char.IsLower(firstLetter))
            {
                number = number * (firstLetter - 96);
            }

            if (char.IsUpper(lastLetter))
            {
                number -= lastLetter - 64;
            }
            else if (char.IsLower(lastLetter))
            {
                number += lastLetter - 96;
            }

            totalSum += number;
        }

        Console.WriteLine("{0:f2}", Math.Round(totalSum, 2, MidpointRounding.AwayFromZero));
    }
}