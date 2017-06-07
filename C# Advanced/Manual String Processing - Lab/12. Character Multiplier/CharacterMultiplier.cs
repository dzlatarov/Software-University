using System;
using System.Linq;

public static class CharacterMultiplier
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string firstString = input[0];
        string secondString = input[1];

        int shorterStringLength = firstString.Length <= secondString.Length
            ? firstString.Length
            : secondString.Length;

        string LongerString = firstString.Length >= secondString.Length
            ? firstString
            : secondString;


        long result = 0;


        for (int i = 0; i < shorterStringLength; i++)
        {
            result += firstString[i] * secondString[i];
        }

        string remainder = LongerString.Substring(shorterStringLength, LongerString.Length - shorterStringLength);

        foreach (var c in remainder)
        {
            result += c + 0;
        }

        Console.WriteLine(result);
    }
}