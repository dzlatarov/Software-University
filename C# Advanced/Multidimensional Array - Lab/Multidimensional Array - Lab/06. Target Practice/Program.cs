using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TargetPractice
{
    public static void Main(string[] args)
    {
        int[] matrixDimensions = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse).ToArray();

        int matrixHeight = matrixDimensions[0];
        int matrixWidth = matrixDimensions[1];

        var snakeMatrix = FilledMatrix(matrixHeight, matrixWidth);

        shotMatrix(snakeMatrix, matrixHeight, matrixWidth);

        var result = DropCharacters(snakeMatrix, matrixHeight, matrixWidth);
        printMatrix(result, matrixHeight, matrixWidth);
    }

    public static char[,] FilledMatrix(int matrixHeight, int matrixWidth)
    {
        string matrixFiller = Console.ReadLine();

        int matrixFillerSize = matrixFiller.Length;

        char[,] matrix = new char[matrixHeight, matrixWidth];

        var matrixFillerQueue = new Queue<char>();

        foreach (char c in matrixFiller)
        {
            matrixFillerQueue.Enqueue(c);
        }

        int counter = 0;

        for (int x = matrixHeight - 1; x >= 0; x--)
        {

            if (counter % 2 == 0)
            {
                for (int y = matrixWidth - 1; y >= 0; y--)
                {

                    char c = matrixFillerQueue.Peek();

                    matrix[x, y] = c;

                    matrixFillerQueue.Enqueue(matrixFillerQueue.Dequeue());
                }
            }
            else
            {
                for (int y = 0; y < matrixWidth; y++)
                {

                    char c = matrixFillerQueue.Peek();

                    matrix[x, y] = c;

                    matrixFillerQueue.Enqueue(matrixFillerQueue.Dequeue());
                }
            }

            counter++;
        }

        return matrix;
    }

    public static void printMatrix(char[][] snakeMatrix, int matrixHeight, int matrixWidth)
    {
        for (int x = 0; x < matrixHeight; x++)
        {
            for (int y = 0; y < matrixWidth; y++)
            {
                Console.Write($"{snakeMatrix[x][y]}");
            }

            Console.WriteLine();
        }
    }

    public static char[,] shotMatrix(char[,] snakeMatrix, int matrixHeight, int matrixWidth)
    {
        int[] shotCoordinates = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        int shotHeight = shotCoordinates[0];
        int shotWidth = shotCoordinates[1];
        int shotRadius = shotCoordinates[2];
        int shotRadiusDiagonal = shotRadius - 1;

        for (int x = shotHeight - shotRadiusDiagonal; x <= shotHeight + shotRadiusDiagonal; x++)
        {
            for (int y = shotWidth - shotRadiusDiagonal; y <= shotWidth + shotRadiusDiagonal; y++)
            {
                try
                {
                    snakeMatrix[x, y] = ' ';
                }
                catch (Exception)
                {

                }
            }
        }

        try
        {
            snakeMatrix[shotHeight + shotRadius, shotWidth] = ' ';
        }
        catch (Exception)
        {

        }

        try
        {
            snakeMatrix[shotHeight - shotRadius, shotWidth] = ' ';
        }
        catch (Exception)
        {

        }

        try
        {
            snakeMatrix[shotHeight, shotWidth + shotRadius] = ' ';
        }
        catch (Exception)
        {

        }

        try
        {
            snakeMatrix[shotHeight, shotWidth - shotRadius] = ' ';
        }
        catch (Exception)
        {

        }


        return snakeMatrix;
    }

    private static char[][] DropCharacters(char[,] snakeMatrix, int matrixHeight, int matrixWidth)
    {

        var matrix = new char[matrixHeight][];

        for(int x = 0; x < matrixHeight; x++)
        {
            var array = new List<char>();
            for (int y = 0; y < matrixWidth; y++)
            {
                array.Add(snakeMatrix[x, y]);
            }

            matrix[x] = array.ToArray();
        }

        int width = matrix[0].Length;

        for (int row = matrix.Length - 1; row >= 0; row--)
        {
            for (int column = 0; column < width; column++)
            {
                if (matrix[row][column] != ' ')
                {
                    continue;
                }

                int currentRow = row - 1;
                while (currentRow >= 0)
                {
                    if (matrix[currentRow][column] != ' ')
                    {
                        matrix[row][column] = matrix[currentRow][column];
                        matrix[currentRow][column] = ' ';
                        break;
                    }

                    currentRow--;
                }
            }
        }

        return matrix;
    }
}