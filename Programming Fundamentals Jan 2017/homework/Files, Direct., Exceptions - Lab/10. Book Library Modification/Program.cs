
namespace _06.Book_Library_Mod
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Globalization;

    public class LibraryTwo
    {
        public static void Main(string[] args)
        {
            Dictionary<string, DateTime> titleDate = new Dictionary<string, DateTime>();

            string[] inputTxt = File.ReadAllLines("input.txt");

            int n = int.Parse(inputTxt[0]);
            char[] ignore = { ' ' };
            for (int i = 1; i <= n; i++)
            {
                string[] input = inputTxt[i].Split(ignore, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                DateTime date = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                titleDate[name] = date;
            }

            List<string> output = new List<string>();
            DateTime after = DateTime.ParseExact(inputTxt.Last(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            foreach (var kvp in titleDate.Where(x => x.Value > after).OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                output.Add($"{kvp.Key} -> {kvp.Value:dd.MM.yyyy}");
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}