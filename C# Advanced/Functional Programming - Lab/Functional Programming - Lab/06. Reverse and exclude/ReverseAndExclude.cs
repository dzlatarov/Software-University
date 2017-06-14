using System;
using System.Linq;

public static class ReverseAndExclude
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var n = int.Parse(Console.ReadLine());

        var result = input
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Where(x => x % n != 0)
            .Reverse()
            .ToArray();

        Console.WriteLine(string.Join(" ", result));
    }
}