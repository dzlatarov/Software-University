using System;
using System.Linq;

public class SquaresInMatrix
{
    public static void Main(string[] args)
    {
        var matrixDimensions = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        int matrixHeight = matrixDimensions[0];
        int matrixWidth = matrixDimensions[1];

        var matrix = new char[matrixHeight][];

        for (int i = 0; i < matrixHeight; i++)
        {
            matrix[i] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse).ToArray();
        }

        int counter = 0;
        for (int x = 0; x < matrixHeight - 1; x++)
        {
            for (int y = 0; y < matrixWidth - 1; y++)
            {
                if (matrix[x][y] == matrix[x + 1][y] && matrix[x][y] == matrix[x][y + 1] &&matrix[x][y] == matrix[x + 1][y + 1])
                {
                    counter++;
                }
            }
        }

        Console.WriteLine(counter);
    }
}