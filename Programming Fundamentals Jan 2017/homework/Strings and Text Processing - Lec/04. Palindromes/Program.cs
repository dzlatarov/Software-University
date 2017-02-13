namespace _04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main(string[] args)
        {
            var ignore = new char[] { ' ', '.', ',', '!', '?' };
            var text = Console.ReadLine().Split(ignore, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var result = new List<string>();
            foreach (var str in text)
            {
                if (str == new string(str.Reverse().ToArray()) && !result.Contains(str))
                {
                    result.Add(str);
                }
            }

            result.Sort();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}