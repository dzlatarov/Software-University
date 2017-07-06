using System;
using System.Collections.Generic;
using System.Linq;

public class GroupNumbers
{
    public static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        var groups = new Dictionary<int, List<int>>();
        groups[0] = new List<int>();
        groups[1] = new List<int>();
        groups[2] = new List<int>();

        foreach (var num in input)
        {
            if(num % 3 == 0)
            {
                groups[0].Add(num);
            }

            if(num % 3 == 1 || num % 3 == -1)
            {
                groups[1].Add(num);
            }

            if(num % 3 == 2 || num % 3 == -2)
            {
                groups[2].Add(num);
            }
        }

        foreach(var kvp in groups)
        {
            foreach (var number in kvp.Value)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}