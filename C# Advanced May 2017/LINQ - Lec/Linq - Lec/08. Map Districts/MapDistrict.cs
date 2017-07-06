using System;
using System.Collections.Generic;
using System.Linq;

public static class MapDistricts
{
    public static void Main(string[] args)
    {
        var cityPopulationEntries = Console.ReadLine()
            .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        var minimumPopulation = long.Parse(Console.ReadLine());

        var cityPopulation = new Dictionary<string, List<long>>();

        foreach (var entry in cityPopulationEntries)
        {
            var tokens = entry
                .Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var name = tokens[0];
            var population = long.Parse(tokens[1]);

            if (!cityPopulation.ContainsKey(name))
            {
                cityPopulation.Add(name, new List<long>());
            }

            cityPopulation[name].Add(population);
        }

        foreach (var kvp in cityPopulation.OrderByDescending(x => x.Value.Sum()))
        {
            if (kvp.Value.Sum() >= minimumPopulation)
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(" ", kvp.Value.OrderByDescending(x => x).Take(5))}");
            }
        }
    }
}