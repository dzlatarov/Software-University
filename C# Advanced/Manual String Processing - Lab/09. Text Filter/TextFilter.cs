using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class TextFilter
{
    public static void Main(string[] args)
    {
        string[] filter = Console.ReadLine()
            .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string text = Console.ReadLine();

        foreach (string word in filter.OrderByDescending(x => x.Length))
        {
            var matcher = new Regex(word);

            var matches = matcher.Matches(text);

            foreach (var match in matches)
            {
                text = text.Replace(match.ToString(), new string('*', word.Length));
            }
        }

        Console.WriteLine(text);
    }
}