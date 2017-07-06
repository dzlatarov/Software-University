using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public static class CubicArtillery
{
    public static void Main(string[] args)
    {
        int bunkerCapacity = int.Parse(Console.ReadLine());
        var bunkers = new Dictionary<char, List<int>>();

        var matcher = new Regex(@"[a-zA-Z][ \d]+");

        while (true)
        {
            var input = Console.ReadLine().Trim();

            if (input == "Bunker Revision")
            {
                break;
            }

            var matches = matcher.Matches(input);

            foreach (Match match in matches)
            {
                var tokens = match.ToString().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(bunkers.ContainsKey(tokens[0]))
            }
        }
    }
}

