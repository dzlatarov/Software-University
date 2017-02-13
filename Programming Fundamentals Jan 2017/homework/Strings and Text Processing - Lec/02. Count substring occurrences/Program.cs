namespace _02.Count_substring_occurrences
{
    using System;

    public class SubstringOccurrences
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var keyWord = Console.ReadLine().ToLower();

            Console.WriteLine(CountSubstring(input, keyWord));
        }

        public static int CountSubstring(string input, string keyWord)
        {
            int count = 0;
            int index = input.IndexOf(keyWord);

            while (index != -1)
            {
                count++;
                index = input.IndexOf(keyWord, index + 1);
            }

            return count;
        }
    }
}