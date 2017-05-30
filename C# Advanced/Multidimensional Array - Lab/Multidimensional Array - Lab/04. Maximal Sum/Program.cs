using System;
using System.Linq;

public class MaximalSum
{
    public static void Main(string[] args)
    {
        var matrixDimensions = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        int matrixHeight = matrixDimensions[0];
        int matrixWidth = matrixDimensions[1];

        var matrix = new int[matrixHeight][];

        for (int i = 0; i < matrixHeight; i++)
        {
            matrix[i] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
        }

        int bestSum = -9001;
        int[,] bestMatrix = new int[3, 3]; 

        for (int x = 0; x < matrixHeight - 2; x++)
        {
            for (int y = 0; y < matrixWidth - 2; y++)
            {
                int currentSum = 0;
                int[,] currentMatrix = new int[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        currentSum += matrix[x + i][y + k];
                        currentMatrix[i, k] = matrix[x + i][y + k];
                    }
                }

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestMatrix = currentMatrix;
                }
            }
        }

        Console.WriteLine($"Sum = {bestSum}");

        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                Console.Write($"{bestMatrix[x, y]} ");
            }
            Console.WriteLine();
        }
    }
}