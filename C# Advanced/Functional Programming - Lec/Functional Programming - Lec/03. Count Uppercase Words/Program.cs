using System;
using System.Linq;

public static class CountUppercaseWords
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        foreach (var uppercaseWord in input.Where(x => char.IsUpper(x[0])))
        {
            Console.WriteLine(uppercaseWord);
        }
    }
}