using System;
using System.Collections.Generic;
using System.Linq;

public class PPlants
{
    public static void Main(string[] args)
    {
        int numberOfPlants = int.Parse(Console.ReadLine());
        int[] pesticidesInEachPlants = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Reverse()
            .ToArray();

        var plants = new Queue<int>();
        for(int i = 0; i <= numberOfPlants; i++)
        {
            plants.Enqueue(pesticidesInEachPlants[i]);
        }

        int lastCount = plants.Count();

        while(true)
        {
            int pesticide = plants.Dequeue();

            if (pesticide <= plants.Peek())
            {
                plants.Enqueue(pesticide);
            }
        }
    }
}

