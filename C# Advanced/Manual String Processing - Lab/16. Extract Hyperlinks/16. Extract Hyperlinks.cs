using System;
using System.Text;
using System.Text.RegularExpressions;

public static class ExtractHyperlinks
{
    public static void Main(string[] args)
    {
        var regex = "<a[^>]*?href\\s*=\\s*(?:(?:'([^>]+?)')|(?:\"([^>]+?)\")|([^>]+?\\s+))(?:(?:\\s*>)|(?:[^>]*?>)).*?<\\/a>";

        StringBuilder allText = new StringBuilder();
        var line = Console.ReadLine();
        while (!line.Equals("END"))
        {
            allText.Append(line);
            line = Console.ReadLine();
        }

        var matches = Regex.Matches(allText.ToString(), regex);
        foreach (Match match in matches)
        {
            if (!match.Groups[1].ToString().Equals(""))
            {
                Console.WriteLine(match.Groups[1]);
            }

            if (!match.Groups[2].ToString().Equals(""))
            {
                Console.WriteLine(match.Groups[2]);
            }

            if (!match.Groups[3].ToString().Equals(""))
            {
                Console.WriteLine(match.Groups[3]);
            }
        }
    }
}