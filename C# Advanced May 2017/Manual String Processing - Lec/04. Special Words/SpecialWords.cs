using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SpecialWords
{
    public static void Main(string[] args)
    {
        string[] keywords = Console.ReadLine()
            .Split(new char[] { '(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string text = Console.ReadLine();

        string[] wordsInText = text
            .Split(new char[] { '(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        var keywordsCount = new Dictionary<string, int>();

        foreach(var keyword in keywords)
        {
            int count = 0;
            for(int i = 0; i < wordsInText.Length; i++)
            {
                if(wordsInText[i] == keyword)
                {
                    count++;
                }
            }

            if(!keywordsCount.ContainsKey(keyword))
            {
                keywordsCount[keyword] = 0;
            }

            keywordsCount[keyword] += count;
        }


        foreach(var kvp in keywordsCount)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value}");
        }
    }
}