using System;
using System.Collections.Generic;

public class PascalTriangle
{
    public static void Main(string[] args)
    {
        int numberOfRows = int.Parse(Console.ReadLine());
        
        long[][] pascalTriangle = new long[numberOfRows][];



        for(int i = 0; i < numberOfRows; i++)
        {
            if (i == 0)
            {
                pascalTriangle[i] = new long[] { 1 };
            }

            else
            {
                int counter = 1;
                var list = new List<long>();
                list.Add(1);
                for (int k = 0; k < i - 1; k++)
                {                  
                    list.Add(pascalTriangle[i - 1][counter - 1] + pascalTriangle[i - 1][counter]);
                    counter++;
                }
                list.Add(1);

                pascalTriangle[i] = list.ToArray();
            }
        }

        int count = 0;
        foreach (var array in pascalTriangle)
        {                  
            Console.WriteLine(string.Join(" ", array));
           
            count++;
        }
    }
}