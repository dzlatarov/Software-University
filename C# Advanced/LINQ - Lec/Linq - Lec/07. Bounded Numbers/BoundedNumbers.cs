using System;
using System.Linq;

public static class BoundedNumbers
{
    public static void Main(string[] args)
    {
        var boundaries = Console.ReadLine()
            .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .OrderBy(x => x)
            .ToArray();

        var numbers = Console.ReadLine()
            .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var result = numbers.Where(x => x >= boundaries[0] && x <= boundaries[1]);

        Console.WriteLine(string.Join(" ", result));
    }
}