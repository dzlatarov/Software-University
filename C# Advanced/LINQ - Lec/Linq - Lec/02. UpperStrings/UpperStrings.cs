using System;
using System.Linq;

public static class UpperStrings
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.ToUpper())
            .ToArray();

        Console.WriteLine(string.Join(" ", input));
    }
}