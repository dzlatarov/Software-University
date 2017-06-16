using System;
using System.Collections.Generic;
using System.Linq;

public static class GroupByGroup
{
    public static void Main(string[] args)
    {
        var groupAndPeople = new Dictionary<int, List<string>>();

        while (true)
        {
            var input = Console.ReadLine();

            if (input == "END")
            {
                break;
            }

            var tokens = input.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var name = $"{tokens[0]} {tokens[1]}";
            var group = int.Parse(tokens[2]);

            if (!groupAndPeople.ContainsKey(group))
            {
                groupAndPeople.Add(group, new List<string>());
            }

            groupAndPeople[group].Add(name);
        }

        foreach (var kvp in groupAndPeople.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
        }
    }
}