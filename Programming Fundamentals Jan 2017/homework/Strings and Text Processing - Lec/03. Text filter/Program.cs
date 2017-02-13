namespace _03.Text_filter
{
    using System;
    using System.Linq;

    public class TextFilter
    {
        public static void Main(string[] args)
        {
            var ignore = new char[] { ' ', ',' };
            var banWords = Console.ReadLine().Split(ignore, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var text = Console.ReadLine();

            foreach (var banWord in banWords)
            {
                text = text.Replace(banWord, new string('*', banWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}