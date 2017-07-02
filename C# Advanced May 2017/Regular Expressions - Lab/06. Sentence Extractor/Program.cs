using System;
using System.Text.RegularExpressions;

public static class SentenceExtractor
{
    public static void Main(string[] args)
    {
        string pattern = @".+?[^.!?]*[.!?]";

        var keyword = new Regex($@" {Console.ReadLine().ToLower()} ");
        string input = Console.ReadLine();

        foreach (Match m in Regex.Matches(input, pattern))
        {
            if (keyword.IsMatch(m.ToString().ToLower()))
            {
                Console.WriteLine(m);
            }
        }
    }
}

