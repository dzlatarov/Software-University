using System;
using System.Linq;


public class MatrixOfPalindromes
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        var x = input[0];
        var y = input[1];
        var matrix = new string[x,y];

        var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        var counterOne = 0;
        var counterTwo = 0;

        for (var k = 0; k < x; k++)
        {
            for (var i = 0; i < y; i++)
            {
                var letters = $"{alphabet[counterOne]}{alphabet[counterTwo]}{alphabet[counterOne]}";

                counterTwo++;

                matrix[k, i] = letters;
            }

            
            counterOne++;
            counterTwo = counterOne;
        }

        for (int i = 0; i < x; i++)
        {
            for (int k = 0; k < y; k++)
            {
                Console.Write($"{matrix[i,k]} ");
            }
            Console.WriteLine();
        }
    }
}