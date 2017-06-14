using System;
using System.Linq;

public static class KnightsOfHonor
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Func<int[], int> f = delegate(int[] s)
        {
            int result = int.MaxValue;

            foreach (var number in s)
            {
                if (result >= number)
                {
                    result = number;
                }
            }

            return result;
        };

        Console.WriteLine(f(input));
    }
}