namespace _4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Armada
    {
        public long SoldierCount { get; set; }
        public int LastActivity { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"(\d+) = (.+) -> (.+):(\d+)");
            Dictionary<string, Dictionary<string, Armada>> legions = new Dictionary<string, Dictionary<string, Armada>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);

                int activity = Convert.ToInt32(match.Groups[1].Value);
                string legionName = match.Groups[2].Value;
                string soldierType = match.Groups[3].Value;
                long soldierCount = Convert.ToInt64(match.Groups[4].Value);

                Armada armada = new Armada
                {
                    LastActivity = activity,
                    SoldierCount = soldierCount
                };

                if (!legions.ContainsKey(legionName))
                {
                    legions[legionName] = new Dictionary<string, Armada>();
                    legions[legionName][soldierType] = armada;
                }
                else
                {
                    if (!legions[legionName].ContainsKey(soldierType))
                    {
                        legions[legionName][soldierType] = armada;
                    }
                    else
                    {
                        legions[legionName][soldierType].LastActivity = activity;
                        legions[legionName][soldierType].SoldierCount += soldierCount;
                    }
                }
            }
            string inputTwo = Console.ReadLine();

            Regex regexOne = new Regex(@"(^\d+)\\(.+)$");
            Match matchOne = regexOne.Match(inputTwo);

            Regex regexTwo = new Regex(@"(.+)");
            Match matchTwo = regexTwo.Match(inputTwo);

            if(matchOne.Success)
            {
                int tillActivity = Convert.ToInt32(matchOne.Groups[1].Value);
                string soldierTypeTomatch = matchOne.Groups[2].Value;

                foreach (var kvp in legions)
                {
                    foreach (var kvpTwo in kvp.Value.OrderByDescending(x => x.Value.LastActivity))
                    {
                        if(kvpTwo.Key == soldierTypeTomatch && kvpTwo.Value.LastActivity < tillActivity)
                        {
                            Console.WriteLine($"{kvp.Key} -> {kvpTwo.Value.SoldierCount}");
                        }
                    }
                }
            }
            else if(matchTwo.Success)
            {
                string soldierTypeTomatch = matchTwo.Groups[1].Value;
                foreach (var kvp in legions)
                {
                    foreach(var kvpTwo in kvp.Value.OrderByDescending(x => x.Value.SoldierCount))
                    {
                        if(kvpTwo.Key == soldierTypeTomatch)
                        {
                            Console.WriteLine($"{kvpTwo.Value.SoldierCount} : {kvp.Key}");
                        }
                    }
                }
            }
        }
    }
}