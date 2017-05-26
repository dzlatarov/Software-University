using System;
using System.Collections.Generic;
using System.Linq;


public class PeriodicTable
{
    public static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());

        var elements = new SortedSet<string>();

        for(int i = 0; i < lines; i++)
        {
            string[] input = Console.ReadLine()
                .Split();

            for(int k = 0; k < input.Length; k++)
            {
                elements.Add(input[k]);
            }
        }

        foreach(string element in elements)
        {
            Console.Write($"{element} ");
        }
    }
}