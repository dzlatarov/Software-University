namespace _10.Pairs_by_Difference
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int count = 0;

            List<int> differentPairs = new List<int>();
            foreach (int number in numbers)
            {
                int counterpart = number - difference;
                if (numbers.Contains(counterpart))
                {
                    count++;
                }
                differentPairs.Add(count);
            }

            Console.WriteLine(differentPairs.Max());
        }
    }
}