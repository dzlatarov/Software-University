namespace _02.Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurrences
    {
        public static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().ToLower().Split().ToList();

            Dictionary<string, int> oddOccurrrences = new Dictionary<string, int>();

            foreach (string str in input)
            {
                if (!oddOccurrrences.ContainsKey(str) && input.Count(x => x == str) % 2 != 0)
                {
                    oddOccurrrences[str] = input.Count(x => x == str);
                }
            }

            Console.WriteLine(string.Join(", ", oddOccurrrences.Keys));
        }
    }
}