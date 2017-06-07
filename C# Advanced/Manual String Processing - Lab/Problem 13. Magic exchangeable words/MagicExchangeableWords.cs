using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class MagicExchangeableWords
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        char[] stringOne = input[0].ToCharArray();
        char[] stringTwo = input[1].ToCharArray();

        var correspondingLetter = new Dictionary<char, char>();

        if (stringOne.Length == stringTwo.Length)
        {
            for (int i = 0; i < stringOne.Length; i++)
            {
                char a = stringOne[i];
                char b = stringTwo[i];

                if (correspondingLetter.ContainsKey(b))
                {
                    stringTwo[i] = correspondingLetter[b];
                }
                else
                {

                    correspondingLetter.Add(b, a);
                }
            }
        }

        Console.WriteLine(stringOne);
        Console.WriteLine(stringTwo);
        if (stringOne == stringTwo)
        {
            Console.WriteLine("true");
        }
    }
}

