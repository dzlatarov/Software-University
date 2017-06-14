using System;
using System.Collections.Generic;
using System.Linq;

public static class CustomComparator
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var even = new List<int>();
        var odd = new List<int>();

        foreach (var number in input)
        {
            if (Math.Abs(number) % 2 == 0)
            {
                even.Add(number);
            }
            else if (Math.Abs(number) % 2 != 0)
            {
                odd.Add(number);
            }
        }
        even.Sort();
        odd.Sort();

        Console.Write(string.Join(" ", even));
        Console.Write(' ');
        Console.WriteLine(string.Join(" ", odd));
    }
}