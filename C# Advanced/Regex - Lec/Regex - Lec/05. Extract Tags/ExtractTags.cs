using System;
using System.Text;
using System.Text.RegularExpressions;

public static class ExtractTags
{
    public static void Main(string[] args)
    {
        StringBuilder text = new StringBuilder();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "END")
            {
                break;
            }

            text.Append(input);
        }

        var matcher = new Regex(@"<.+?>");

        var matches = matcher.Matches(text.ToString());

        foreach (Match match in matches)
        {
            Console.WriteLine(match.ToString());
        }
    }
}