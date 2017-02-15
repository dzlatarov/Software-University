namespace _05.Magic_exchangeable_words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MagicExchangeableWords
    {
        public static void Main(string[] args)
        {
            char[] ignore = new char[] { ' ' };
            string[] input = Console.ReadLine().Split(ignore, StringSplitOptions.RemoveEmptyEntries).ToArray();

            StringBuilder str1 = new StringBuilder(input[0]);
            StringBuilder str2 = new StringBuilder(input[1]);
            Console.WriteLine(MagicalWords(str1, str2));
        }

        public static bool MagicalWords(StringBuilder str1, StringBuilder str2)
        {
            List<char> replaced = new List<char>();
            List<char> oldReplaced = new List<char>();
            List<char> smd = new List<char>();
    
            for (int i = 0; i < str1.Length; i++)
            {
                if (oldReplaced.Contains(str1[i]))
                {
          
                }
                else if (!replaced.Contains(str2[i]) )
                {
                    str1 = str1.Replace(str1[i], str2[i]);

                    replaced.Add(str2[i]);
                    oldReplaced.Add(str1[i]);
                }
            }

            Console.WriteLine(str1);
            if (string.Join("", str1) == string.Join("", str2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}