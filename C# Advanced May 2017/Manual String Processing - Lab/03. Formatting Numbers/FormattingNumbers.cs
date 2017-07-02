using System;
using System.Linq;

public class FormattingNumbers
{
    public static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine()
            .Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string stringNumberOne = numbers[0].Trim();
        string stringNumberTwo = numbers[1].Trim();
        string stringNumberThree = numbers[2].Trim();

        int numberOne = int.Parse(stringNumberOne);
        double numberTwo = double.Parse(stringNumberTwo);
        string numberTwoString = $"{numberTwo:0.00}";
        double numberThree = double.Parse(stringNumberThree);
        string doubleThreeString = $"{numberThree:0.000}";

        Console.WriteLine("|{0}|{1}|{2}|{3}|", 
            numberOne.ToString("X").PadRight(10, ' '),
            Convert.ToString(numberOne, 2).PadLeft(10, '0').Substring(0, 10),
            numberTwoString.PadLeft(10, ' '),
            doubleThreeString.PadRight(10, ' ')
            );
    }
}