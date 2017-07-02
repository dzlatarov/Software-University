using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public static class ReplaceTag
{
    public static void Main(string[] args)
    {
        var sb = new StringBuilder();

        string pattern = @"<a (href=.+?)>(.+)</a>";

        while (true)
        {
            var input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }

            sb.AppendLine(input);
        }

        var result = Regex.Replace(sb.ToString(), pattern, @"[URL $1]$2[/URL]");

        Console.WriteLine(result);
    }
}