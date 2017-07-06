using System;
using System.Linq;

public static class KnightOfHonor
{
    public static void Main(string[] args)
    {
        Action<string> AddSir = input => Console.WriteLine(String.Join("\n", input
            .Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => String.Format($"Sir {x}"))
            .ToArray()));

        AddSir(Console.ReadLine());
    }
}