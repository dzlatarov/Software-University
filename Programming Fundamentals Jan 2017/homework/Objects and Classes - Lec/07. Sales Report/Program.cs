namespace _07.Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Sales
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, double> sales = new SortedDictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string town = input[0];
                double totalSales = Convert.ToDouble(input[input.Length - 1]) * Convert.ToDouble(input[input.Length - 2]);

                if (!sales.ContainsKey(town))
                {
                    sales[town] = totalSales;
                }
                else
                {
                    sales[town] += totalSales;
                }
            }

            foreach (var kvp in sales)
            {
                Console.WriteLine($"{kvp.Key:F2} -> {kvp.Value:F2}");
            }
        }
    }
}