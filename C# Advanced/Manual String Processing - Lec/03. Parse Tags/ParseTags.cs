using System;
using System.Text.RegularExpressions;

public class ParseTags
{
    public static void Main(string[] args)
    {
        string text = Console.ReadLine();

        var matcher = new Regex(@"(<upcase>)(.+?)(<\/upcase>)");

        var matches = matcher.Matches(text);

        foreach(Match match in matches)
        {
            text = text.Replace(match.ToString(), match.Groups[2].ToString().ToUpper());
        }

        Console.WriteLine(text);
    }
}