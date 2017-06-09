using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class SrubskoUnleashed
{
    public static void Main(string[] args)
    {
        var singersRevenue = new Dictionary<string, Dictionary<string, int>>();

        var matcher = new Regex(@"(.+) @(.+) (\d+) (\d+)");

        while(true)
        {
            string input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }
            else if (matcher.IsMatch(input))
            {
                var groups = matcher.Match(input);

                string place = groups.Groups[2].ToString();
                string singer = groups.Groups[1].ToString();
                int revenue = int.Parse(groups.Groups[3].ToString()) * int.Parse(groups.Groups[4].ToString());
                
                if(!singersRevenue.ContainsKey(place))
                {
                    singersRevenue.Add(place, new Dictionary<string, int>());
                }

                if(!singersRevenue[place].ContainsKey(singer))
                {
                    singersRevenue[place].Add(singer, 0);
                }

                singersRevenue[place][singer] += revenue;
            }
        }

        foreach(var place in singersRevenue)
        {
            Console.WriteLine(place.Key);
            foreach (var singer in place.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
            }
        }
    }
}