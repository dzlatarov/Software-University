using System;
using System.Linq;

public static class TriFunction
{
    public static void Main(string[] args)
    {
        var charSum = int.Parse(Console.ReadLine());
        var strings = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        foreach (var str in strings)
        {
            var sum = str.ToCharArray().Select(z => z + 0).Sum();

            if (sum >= charSum)
            {
                Console.WriteLine(str);
                break;
            }
        }
    }
}