using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Palindromes
{
    private static bool IsPalyndrome(string word)
    {
        if (word.Length == 1)
            return true;
        int len = word.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (word[i] != word[len - i - 1])
                return false;
        }
        return true;
    }

    static void Main()
    {
        char[] delimiters = { ' ', ',', '.', '?', '!' };
        SortedSet<string> palyndromes = new SortedSet<string>();
        List<string> words = Console.ReadLine().
            Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();

        foreach (string word in words)
        {
            if (IsPalyndrome(word))
                palyndromes.Add(word);
        }
        Console.WriteLine($"[{string.Join(", ", palyndromes)}]");
    }
}