namespace _07.Count_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.Sort();

            List<int> numbersNonDupes = new List<int>();
            List<int> numbersCount = new List<int>();
            foreach (int i in numbers)
            {
                if (!numbersNonDupes.Contains(i))
                {
                    numbersNonDupes.Add(i);
                    numbersCount.Add(numbers.Count(x => x == i));
                }
            }

            for (int i = 0; i < numbersNonDupes.Count; i++)
            {
                Console.WriteLine($"{numbersNonDupes[i]} -> {numbersCount[i]}");
            }
        }
    }
}