namespace _05.Short_Words_Sorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main(string[] args)
        {
            char[] ignore = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
            List<string> input = Console.ReadLine().ToLower().Split(ignore, StringSplitOptions.RemoveEmptyEntries).ToList();
            input.Distinct();

            SortedDictionary<string, int> sorted = new SortedDictionary<string, int>();
            foreach (string str in input)
            {
                if (str.Length < 5)
                {
                    sorted[str] = str.Length;
                }
            }

            Console.WriteLine(string.Join(", ", sorted.Keys));
        }
    }
}