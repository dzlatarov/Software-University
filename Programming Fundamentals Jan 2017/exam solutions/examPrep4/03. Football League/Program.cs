namespace _03.Football_League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class FootballLeague
    {
        public static void Main(string[] args)
        {
            string key = Console.ReadLine();
            key = Regex.Escape(key);
            Dictionary<string, int> countryScore = new Dictionary<string, int>();
            Dictionary<string, int> countryTopGoals = new Dictionary<string, int>();

            Regex regex = new Regex($@"{key}(.+?|){key}.+{key}(.+?|){key}.+(\d+):(\d+)");
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "final")
                {
                    break;
                }
                else
                {
                    var match = regex.Match(input);

                    var teamOne = new string(match.Groups[1].Value.ToUpper().Reverse().ToArray()).ToString();
                    var teamTwo = new string(match.Groups[2].Value.ToUpper().Reverse().ToArray()).ToString();
                    int goalsOne = Convert.ToInt32(match.Groups[3].Value);
                    int goalsTwo = Convert.ToInt32(match.Groups[4].Value);

                    Score(teamOne, teamTwo, goalsOne, goalsTwo, countryScore, countryTopGoals);
                }
            }

            Console.WriteLine("League standings:");
            int counter = 1;
            foreach (var kvp in countryScore.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{counter}. {kvp.Key} {kvp.Value}");
                counter++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var kvp in countryTopGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine($"- {kvp.Key} -> {kvp.Value}");
            }
        }

        public static void Score(string teamOne, string teamTwo, int goalsOne, int goalsTwo, Dictionary<string, int> countryScore, Dictionary<string, int> countryTopGoals)
        {
            if (goalsOne > goalsTwo)
            {
                if (!countryScore.ContainsKey(teamOne))
                {
                    countryScore[teamOne] = 3;
                }
                else
                {
                    countryScore[teamOne] += 3;
                }

                if (!countryScore.ContainsKey(teamTwo))
                {
                    countryScore[teamTwo] = 0;
                }
            }
            else if (goalsTwo > goalsOne)
            {
                if (!countryScore.ContainsKey(teamTwo))
                {
                    countryScore[teamTwo] = 3;
                }
                else
                {
                    countryScore[teamTwo] += 3;
                }

                if (!countryScore.ContainsKey(teamOne))
                {
                    countryScore[teamOne] = 0;
                }
            }
            else if (goalsOne == goalsTwo)
            {
                if (!countryScore.ContainsKey(teamOne))
                {
                    countryScore[teamOne] = 1;
                }
                else
                {
                    countryScore[teamOne] += 1;
                }

                if (!countryScore.ContainsKey(teamTwo))
                {
                    countryScore[teamTwo] = 1;
                }
                else
                {
                    countryScore[teamTwo] += 1;
                }
            }

            if (!countryTopGoals.ContainsKey(teamOne))
            {
                countryTopGoals[teamOne] = goalsOne;
            }
            else
            {
                countryTopGoals[teamOne] += goalsOne;
            }

            if (!countryTopGoals.ContainsKey(teamTwo))
            {
                countryTopGoals[teamTwo] = goalsTwo;
            }
            else
            {
                countryTopGoals[teamTwo] += goalsTwo;
            }
        }
    }
}