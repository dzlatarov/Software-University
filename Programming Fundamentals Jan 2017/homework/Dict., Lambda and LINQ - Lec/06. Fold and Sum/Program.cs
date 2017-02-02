namespace _06.Fold_and_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> rowOne = new List<int>();

            List<int> result = new List<int>();
            int k = numbers.Count / 4;

            rowOne.AddRange(numbers.Take(k).Reverse());
            numbers.RemoveRange(0, k);
            numbers.Reverse();
            rowOne.AddRange(numbers.Take(k));
            numbers.RemoveRange(0, k);
            numbers.Reverse();

            for (int i = 0; i < rowOne.Count; i++)
            {
                result.Add(rowOne[i] + numbers[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}