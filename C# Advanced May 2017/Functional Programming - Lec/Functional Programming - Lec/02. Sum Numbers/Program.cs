using System;
using System.Linq;

public static class SumNumbers
{
    public static void Main(string[] args)
    {
        int[] input = Console.ReadLine()
            .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine(input.Length);
        Console.WriteLine(input.Sum());
    }
}