using System;
using System.Linq;

public class DiagonalDifference
{
    public static void Main(string[] args)
    {
        int matrixSize = int.Parse(Console.ReadLine());

        var matrix = new int[matrixSize][];

        for (int i = 0; i < matrixSize; i++)
        {
            matrix[i] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
        }

        int sumLeft = 0;
        int sumRight = 0;

        for (int space = 0; space < matrixSize; space++)
        {
            sumLeft += matrix[space][space];
            sumRight += matrix[space][matrixSize - space - 1];
        }

        FindDifference(sumLeft, sumRight);
    }

    public static void FindDifference(int sumLeft, int sumRight)
    {
        if (sumLeft >= sumRight)
        {
            Console.WriteLine(sumLeft - sumRight);            
        }
        else
        {
            Console.WriteLine(sumRight - sumLeft);
        }
    }
}