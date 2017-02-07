namespace _06.Book_Library_Mod
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class LibraryTwo
    {
        public static void Main(string[] args)
        {
            Dictionary<string, DateTime> titleDate = new Dictionary<string, DateTime>();

            int n = int.Parse(Console.ReadLine());
            char[] ignore = { ' ' };
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(ignore, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                DateTime date = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                titleDate[name] = date;
            }

            DateTime after = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            foreach (var kvp in titleDate.Where(x => x.Value > after).OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:dd.MM.yyyy}");
            }

            //why would someone ever use objects for this problem is beyond me
        }
    }
}