namespace _04.Largest_3_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x).Take(3)));
        }
    }
}