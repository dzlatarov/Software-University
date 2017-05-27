using System;
using System.Collections.Generic;
using System.Linq;

public class PopulationCounter
{
    public static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, long>> populations = new Dictionary<string, Dictionary<string, long>>();

        while (true)
        {
            Dictionary<string, long> cityPopulation = new Dictionary<string, long>();

            List<string> input = Console.ReadLine().Split('|').ToList();

            if (input[0] == "report")
            {
                break;
            }
            else if (!populations.ContainsKey(input[1]))
            {
                cityPopulation[input[0]] = Convert.ToInt64(input[2]);

                populations[input[1]] = cityPopulation;
            }
            else
            {
                cityPopulation = populations[input[1]];

                if (cityPopulation.ContainsKey(input[0]))
                {
                    cityPopulation[input[0]] += Convert.ToInt64(input[2]);
                }
                else
                {
                    cityPopulation.Add(input[0], Convert.ToInt64(input[2]));
                }

                populations[input[1]] = cityPopulation;
            }
        }

        foreach (var town in populations.OrderByDescending(x => x.Value.Sum(y => y.Value)))
        {
            List<long> sumOfTowns = town.Value.Select(x => x.Value).ToList();
            Console.WriteLine($"{town.Key} (total population: {sumOfTowns.Sum()})");

            Console.Write($"=>{string.Join("=>", town.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
        }
    }
}