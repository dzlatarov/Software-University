﻿using System;
using System.Text.RegularExpressions;

public static class ExtractQuatations
{
    public static void Main(string[] args)
    {
        string text = Console.ReadLine();

        var matcher = new Regex(@"'(.+?)'|""(.+?)""");

        var matches = matcher.Matches(text);

        foreach (Match match in matches)
        {
            if (match.ToString().StartsWith("'"))
            {
                Console.WriteLine(match.Groups[1].ToString());
            }
            else
            {
                Console.WriteLine(match.Groups[2].ToString());
            }
        }
    }
}