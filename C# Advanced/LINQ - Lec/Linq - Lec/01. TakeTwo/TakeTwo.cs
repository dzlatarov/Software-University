using System;
using System.Linq;

public static class TakeTwo
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var result = input.Distinct()
            .Where(x => 10 <= x && x <= 20)
            .Take(2);

        Console.WriteLine(string.Join(" ", result));
    }
}