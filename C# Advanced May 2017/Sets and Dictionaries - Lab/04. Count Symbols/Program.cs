using System;
using System.Collections.Generic;

public class CountSymbols
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        var symbolsCount = new SortedDictionary<char, int>();

        foreach(char c in input)
        {
            if(!symbolsCount.ContainsKey(c))
            {
                symbolsCount.Add(c, 1);
            }
            else
            {
                symbolsCount[c]++;
            }
        }

        foreach(var kvp in symbolsCount)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
        }
    }
}