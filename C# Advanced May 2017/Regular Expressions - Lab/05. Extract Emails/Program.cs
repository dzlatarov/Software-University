using System;

using System.Text.RegularExpressions;

public static class ExtractEmails
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        var matcher = new Regex(@"[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                + "@"
                                + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))");

        var matches = matcher.Matches(input);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.ToString());
        }
    }
}