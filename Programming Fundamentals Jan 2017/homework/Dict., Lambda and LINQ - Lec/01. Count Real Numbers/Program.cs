namespace _01.Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        public static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, int> countNumbers = new SortedDictionary<double, int>();

            foreach (double number in numbers)
            {
                countNumbers[number] = numbers.Count(x => x == number);
            }

            foreach (KeyValuePair<double, int> kvp in countNumbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}