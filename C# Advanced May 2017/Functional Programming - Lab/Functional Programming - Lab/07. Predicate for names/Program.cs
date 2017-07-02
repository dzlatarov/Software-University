using System;
using System.Linq;

public static class PredicateForNames
{
    public static void Main(string[] args)
    {
        var lenght = int.Parse(Console.ReadLine());

        var results = Console.ReadLine()
            .Split(new char[] {' ', '\t', ','}, StringSplitOptions.RemoveEmptyEntries)
            .Where(x => x.Length <= lenght)
            .ToArray();

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }


    }
}