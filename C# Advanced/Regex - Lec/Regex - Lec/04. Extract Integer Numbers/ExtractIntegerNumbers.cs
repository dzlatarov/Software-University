using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class ExtractIntegerNumbers
{
    public static void Main(string[] args)
    {
        string text = Console.ReadLine();

        var matcher = new Regex(@"\d+");

        var matches = matcher.Matches(text);

        var results = new List<string>();

        foreach (Match match in matches)
        {
            results.Add(match.ToString());
        }

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
}