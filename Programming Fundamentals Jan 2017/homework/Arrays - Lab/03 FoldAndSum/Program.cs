namespace _03_FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split().Select(int.Parse).ToList();
            int k = array.Count / 4;

            List<int> rowOneLeft = new List<int>();
            List<int> rowOneRight = new List<int>();

            for (int i = 0; i < k; i++)
            {
                rowOneLeft.Add(array[i]);
            }

            rowOneLeft.Reverse();

            array.Reverse();

            for (int i = 0; i < k; i++)
            {
                rowOneRight.Add(array[i]);
            }

            array.Reverse();

            List<int> topLine = rowOneLeft.Concat(rowOneRight).ToList();

            int[] result = new int[topLine.Count];
            for (int i = 0; i < topLine.Count; i++)
            {
                result[i] = topLine[i] + array[k + i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}