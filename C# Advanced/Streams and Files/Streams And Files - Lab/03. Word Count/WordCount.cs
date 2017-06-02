using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class WordCount
{
    public static void Main(string[] args)
    {
        var words = new StreamReader(Path.GetFullPath("words.txt"));
        var text = new StreamReader(Path.GetFullPath("text.txt"));
        var result = new StreamWriter(Path.GetFullPath("result.txt"));

        var wordCount = new Dictionary<string, int>();

        while (!words.EndOfStream)
        {
            string word = words.ReadLine().ToLower();
            int counter = 0;

            while (!text.EndOfStream)
            {
                string line = text.ReadLine().ToLower();

                Console.WriteLine(line);
                Console.WriteLine(word);
                if (line.Contains(word))
                {
                    counter++;
                }
            }

            wordCount.Add(word, counter);
            text.DiscardBufferedData();
            text.BaseStream.Seek(0, SeekOrigin.Begin);
        }

        foreach(var kvp in wordCount.OrderByDescending(x => x.Value))
        {
            result.WriteLine($"{kvp.Key} - {kvp.Value}");
        }

        result.Flush();
    }
}