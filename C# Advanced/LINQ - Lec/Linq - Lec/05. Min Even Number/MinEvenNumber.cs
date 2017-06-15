using System;
using System.Linq;

public static class MinEvenNumbers
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split(new char[] {}, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToList();

        try
        {
            var result = input
                .Where(x => Math.Abs(x) % 2 == 0)
                .Min();

            Console.WriteLine($"{result:f2}");
        }
        catch (Exception)
        {
            Console.WriteLine("No match");
        }
    }
}