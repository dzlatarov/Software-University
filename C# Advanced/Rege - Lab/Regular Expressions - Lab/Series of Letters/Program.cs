using System;
using System.Collections.Generic;
using System.Linq;

public static class SeriesOfLetters
{
    public static void Main()
    {
        List<char> result = new List<char>();

        string input = Console.ReadLine();

        char lastChar = '*';

        foreach (char c in input)
        {
            if (lastChar != c)
            {
                result.Add(c);

                lastChar = c;
            }
        }

        Console.WriteLine(string.Join(string.Empty, result));
    }
}