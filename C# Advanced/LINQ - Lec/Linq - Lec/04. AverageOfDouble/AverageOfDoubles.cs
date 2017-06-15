using System;
using System.Linq;

public static class AverageOfDoubles
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToList();

        Console.WriteLine($"{input.Average():f2}");
    }
}