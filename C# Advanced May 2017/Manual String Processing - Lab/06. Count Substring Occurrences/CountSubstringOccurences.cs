using System;
using System.Text.RegularExpressions;


public static class CountSubstringOccurences
{
    public static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string matchSubstring = Console.ReadLine();

        var matcher = new Regex(matchSubstring.ToLower());

        int totalMatches = 0;
        for (int i = 0; i < text.Length - matchSubstring.Length + 1; i++)
        {
            if (matcher.IsMatch(text.Substring(i, matchSubstring.Length).ToLower()))
            {
                totalMatches++;
            }
        }

        Console.WriteLine(totalMatches);
    }
}