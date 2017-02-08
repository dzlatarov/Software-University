namespace _03.Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordCount
    {
        public static void Main(string[] args)
        {
            var words = File.ReadAllText("words.txt").Split(' ').ToArray();

            string[] input = File.ReadAllText("input.txt").ToLower().Split(new char[] { ' ', '?', '!', '-', '\n', '\r', ',', '.', '\'', '…' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string str in words)
            {
                dict.Add(str, input.Where(x => x == str).Count());
            }

            List<string> output = new List<string>();
            foreach (KeyValuePair<string, int> kvp in dict.OrderByDescending(x => x.Value))
            {
                output.Add($"{kvp.Key} - {kvp.Value}");
            }

            File.WriteAllText("output.txt", string.Join(Environment.NewLine, output));
        }
    }
}
