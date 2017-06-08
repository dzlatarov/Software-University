using System;
using System.Text.RegularExpressions;

public static class MatchCount
{
    public static void Main(string[] args)
    {
        var matcher = new Regex(Console.ReadLine());

        string text = Console.ReadLine();

        var matches = matcher.Matches(text);

        int counter = 0;

        foreach (Match match in matches)
        {
            counter++;
        }

        Console.WriteLine(counter);
    }
}