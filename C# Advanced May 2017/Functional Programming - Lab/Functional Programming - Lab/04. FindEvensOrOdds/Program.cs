using System;
using System.Collections.Generic;
using System.Linq;

public static class FindEvensOrOdds
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var oddOrEven = Console.ReadLine();

        var result = new List<int>();

        int start = input[0];
        int end = input[1];

        for (int i = start; i <= end; i++)
        {
            if (oddOrEven == "odd")
            {
                if (i % 2 != 0)
                {
                    result.Add(i);
                }
            }
            else if (oddOrEven == "even")
            {
                if (i % 2 == 0)
                {
                    result.Add(i);
                }
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}