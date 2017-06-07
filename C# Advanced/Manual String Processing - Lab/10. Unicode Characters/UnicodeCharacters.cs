using System;

public static class UnicodeCharacters
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        foreach (var chr in input)
        {
            Console.Write("\\u{0:x4}", (int)chr);
        }
        Console.WriteLine();
    }
}