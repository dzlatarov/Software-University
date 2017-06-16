using System;
using System.Collections.Generic;
using System.Linq;

public static class StudentsByGroup
{
    public static void Main(string[] args)
    {
        var result = new Dictionary<string, int>();
        while (true)
        {
            var input = Console.ReadLine().Trim();

            if (input == "END")
            {
                break;
            }

            var inputTokens = input
                .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var name = $"{inputTokens[0]} {inputTokens[1]}";
            var group = int.Parse(inputTokens[2]);

            result.Add(name, group);
        }

        foreach (var kvp in result.OrderBy(x => x.Key).Where(x => x.Value == 2))
        {
            Console.WriteLine(kvp.Key);
        }

    }
}