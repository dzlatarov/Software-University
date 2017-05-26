using System;
using System.Collections.Generic;
using System.Linq;

public class SetsOfElements
{
    public static void Main(string[] args)
    {
        int[] setsSizes = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var setOne = new SortedSet<int>();
        var setTwo = new SortedSet<int>();

        var result = new SortedSet<int>();

        for(int i = 0; i < setsSizes[0]; i++)
        {
            setOne.Add(int.Parse(Console.ReadLine()));
        }

        for (int i = 0; i < setsSizes[1]; i++)
        {
            setTwo.Add(int.Parse(Console.ReadLine()));
        }

        foreach(int n in setOne)
        {
            if(setTwo.Contains(n))
            {
                result.Add(n);
            }
        }

        foreach(int n in result)
        {
            Console.Write($"{n} ");
        }
    }
}