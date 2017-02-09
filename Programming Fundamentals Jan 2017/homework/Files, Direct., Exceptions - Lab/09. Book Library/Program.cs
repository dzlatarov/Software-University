
namespace _05.Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class Library
    {
        public static void Main(string[] args)
        {
            string[] inputTxt = File.ReadAllLines("input.txt");
            Dictionary<string, double> authorRevenue = new Dictionary<string, double>();

            int n = int.Parse(inputTxt[0]);
            for (int i = 1; i <= n; i++)
            {
                string[] input = inputTxt[i].Split(' ').ToArray();
                string name = input[1];
                double price = Convert.ToDouble(input[5]);

                if (!authorRevenue.ContainsKey(name))
                {
                    authorRevenue[name] = price;
                }
                else
                {
                    authorRevenue[name] += price;
                }
            }

            List<string> output = new List<string>();
            foreach (var kvp in authorRevenue.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                output.Add($"{kvp.Key} -> {kvp.Value:F2}");
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}
