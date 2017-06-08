using System;

public static class DigitCount
{
    public static void Main(string[] args)
    {
        char[] text = Console.ReadLine().ToCharArray();

        int counter = 0;
        foreach (var c in text)
        {
            if (!char.IsDigit(c))
            {
                counter++;
            }
        }

        Console.WriteLine("Non-digits: {0}", counter);
    }
}