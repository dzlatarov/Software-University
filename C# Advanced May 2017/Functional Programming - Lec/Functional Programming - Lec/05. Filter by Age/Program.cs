using System;
using System.Collections.Generic;
using System.Linq;

public static class FilterByAge
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> nameAndAge = new Dictionary<string, int>();

        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        { 
            string input = Console.ReadLine();

            string[] tokens = input
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string name = tokens[0];
            int age = int.Parse(tokens[1]);

            nameAndAge.Add(name, age);
        }

        string olderOrYounger = Console.ReadLine();
        int filterAge = int.Parse(Console.ReadLine());
        string[] displayWhat = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        nameAndAge = NameAndAgeFiltered(nameAndAge, olderOrYounger, filterAge);
        Result(nameAndAge, displayWhat);
    }

    public static Dictionary<string, int> NameAndAgeFiltered(Dictionary<string, int> nameAndAge, string olderOrYounger, int filterAge)
    {
        if (olderOrYounger == "older")
        {
            return nameAndAge
                .Where(x => x.Value >= filterAge)
                .ToDictionary(pair => pair.Key,
                    pair => pair.Value);
        }

        return nameAndAge
            .Where(x => x.Value < filterAge)
            .ToDictionary(pair => pair.Key,
                pair => pair.Value);
    }

    public static void Result(Dictionary<string, int> nameAndAge, string[] displayWhat)
    {
        if (displayWhat.Length == 2)
        {
            foreach (var kvp in nameAndAge)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
        else if (displayWhat[0] == "name")
        {
            foreach (var kvp in nameAndAge)
            {
                Console.WriteLine($"{kvp.Key}");
            }
        }
        else
        {
            foreach (var kvp in nameAndAge)
            {
                Console.WriteLine($"{kvp.Value}");
            }
        }
    }
}