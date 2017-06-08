using System;
using System.Text.RegularExpressions;

public static class VowelCount
{
    public static void Main(string[] args)
    {
        string text = Console.ReadLine();

        var matcher = new Regex(@"[a|A|e|E|i|I|o|O|u|U|y|Y]");

        var matches = matcher.Matches(text);

        int vowelCount = 0;

        foreach (Match match in matches)
        {
            vowelCount++;
        }

        Console.WriteLine("Vowels: {0}", vowelCount);
    }
}