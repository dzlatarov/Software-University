namespace _04.Sum_Reversed_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumReversedNumbers
    {
        public static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            List<double> reversedNumbers = new List<double>();

            foreach (double d in numbers)
            {
                reversedNumbers.Add(Convert.ToDouble(new string(d.ToString().Reverse().ToArray())));
            }

            Console.WriteLine(reversedNumbers.Sum());
        }
    }
}