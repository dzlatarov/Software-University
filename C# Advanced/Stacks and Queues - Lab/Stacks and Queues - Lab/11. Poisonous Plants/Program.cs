using System;
using System.Collections.Generic;
using System.Linq;

public class PoisonousPlants
{
    public static void Main(string[] args)
    {
        int plantsCount = int.Parse(Console.ReadLine());

        List<int> allPlants = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();

        allPlants
            .RemoveRange(allPlants.Count() - plantsCount, allPlants.Count() - plantsCount);


        Console.WriteLine(DaysNeeded(allPlants));
    }

    public static int DaysNeeded(List<int> allPlants)
    {
        int previousRemovedPlantsCount = 0;
        int days = 0;       

        while (true)
        {
            int startingIndex = allPlants.Count() - 1;

            for (int i = startingIndex; i >= 1; i--)
            {
                if (allPlants[i] > allPlants[i - 1])
                {
                    allPlants[i] = -1;
                    previousRemovedPlantsCount++;
                }               
            }

            if(previousRemovedPlantsCount == 0)
            {
                break;
            }

            days++;

            previousRemovedPlantsCount = 0;

            allPlants.RemoveAll(x => x == -1);
        }

        return days;
    }
}
