namespace _04.Split_by_Word_Casing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByWordCasing
    {
        public static void Main(string[] args)
        {
            var separators = new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' };
            List<string> text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                if (text[i].Any(ch => !char.IsLetter(ch)))
                {
                    mixedCase.Add(text[i]);
                }
                else if (text[i] == text[i].ToUpper())
                {
                    upperCase.Add(text[i]);
                }
                else if (text[i] == text[i].ToLower())
                {
                    lowerCase.Add(text[i]);
                }
                else
                {
                    mixedCase.Add(text[i]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}