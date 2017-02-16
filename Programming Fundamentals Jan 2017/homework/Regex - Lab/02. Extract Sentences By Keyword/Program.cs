namespace _02.Extract_Sentences_By_Keyword
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ExtractSentencesByKeyword
    {
        public static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string sentences = Console.ReadLine();

            char[] ignore = new char[] { '?', '!', '.', };
            string[] splitSentences = sentences.Split(ignore).ToArray();

            var nonWords = new Regex(@"[^\w+]");
            foreach (string str in splitSentences)
            {
                string strTemp = nonWords.Replace(str, @" ");

                string[] words = strTemp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (string word in words)
                {
                    if (word == $"{keyword}")
                    {
                        Console.WriteLine(str.TrimStart(' '));
                        break;
                    }
                }
            }
        }
    }
}