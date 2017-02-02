namespace _03.Sum__Min__Max__Average
{
    using System;
    using System.Linq;

    public class SumMinMAxAverage
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];

            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {input.Sum()}");
            Console.WriteLine($"Min = {input.Min()}");
            Console.WriteLine($"Max = {input.Max()}");
            Console.WriteLine($"Average = {(double)input.Average()}");
        }
    }
}