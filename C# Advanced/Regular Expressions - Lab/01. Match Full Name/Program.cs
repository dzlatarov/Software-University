using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public static class MatchFullName
{
    public static void Main()
    {
        string input = string.Empty;

        var matcher = new Regex(@"[A-Z][a-z]+ [A-Z][a-z]+");

        while (input != "end")
        {
            input = Console.ReadLine();

            if (matcher.IsMatch(input))
            {
                Console.WriteLine(input);
            }
        }
    }
}