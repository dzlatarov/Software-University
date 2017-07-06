using System;
using System.Collections.Generic;
using System.Linq;

public static class SortEvenNumbers
{
    public static void Main(string[] args)
    {
        List<int> input = Console.ReadLine()
            .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Where(x => x % 2 == 0)
            .ToList();

        input.Sort();

        Console.WriteLine(string.Join(", ", input));
    }
}