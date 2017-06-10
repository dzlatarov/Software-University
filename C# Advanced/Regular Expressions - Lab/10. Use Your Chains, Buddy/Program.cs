using System;
using System.Text;
using System.Text.RegularExpressions;

public class UseYourChainsBuddy
{
    public static void Main()
    {
        const int characterOffset = 'n' - 'a';
        string input = Console.ReadLine();

        Regex symbolsPattern = new Regex(@"[^a-z0-9]+");
        Regex whitespacePattern = new Regex(@"\s+");

        var matches = Regex.Matches(input, @"<p>(.*?)<\/p>");

        StringBuilder result = new StringBuilder();

        foreach (Match match in matches)
        {
            string currentEntry = match.Groups[1].ToString();

            currentEntry = symbolsPattern.Replace(currentEntry, " ");
            currentEntry = whitespacePattern.Replace(currentEntry, " ");

            foreach (var symbol in currentEntry)
            {
                if ('a' <= symbol && symbol <= 'm')
                {
                    result.Append((char)(symbol + characterOffset));
                }
                else if ('n' <= symbol && symbol <= 'z')
                {
                    result.Append((char)(symbol - characterOffset));
                }
                else
                {
                    result.Append(symbol);
                }
            }
        }

        Console.WriteLine(result);
    }
}