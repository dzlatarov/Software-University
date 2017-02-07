namespace _05.Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Library
    {
        public static void Main(string[] args)
        {
            Dictionary<string, double> authorRevenue = new Dictionary<string, double>();

            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string name = input[1];
                double price = Convert.ToDouble(input[5]);

                if(!authorRevenue.ContainsKey(name))
                {
                    authorRevenue[name] = price;
                }
                else
                {
                    authorRevenue[name] += price;
                }
            }

            foreach(var kvp in authorRevenue.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }

            //why would someone ever use objects for this problem is beyond me
        }
    }
}