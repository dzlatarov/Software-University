using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sum2x2Submatrix
{
    public static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int x = input[0];
        int y = input[1];

        int[][] matrix = new int[x][];

        for (int rows = 0; rows < x; rows++)
        {
            matrix[rows] = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        int[,] bestResultMatrix = new int[2, 2];
        int bestResult = 0;

        for(int row = 0; row < x - 1; row++)
        {
            for(int col = 0; col < y - 1; col++)
            {
                int result = matrix[row][col] + matrix[row + 1][col] + matrix[row][col + 1] + matrix[row + 1][col + 1];

                if(result > bestResult)
                {
                    bestResult = result;

                    bestResultMatrix[0, 0] = matrix[row][col];
                    bestResultMatrix[1, 0] = matrix[row + 1][col];
                    bestResultMatrix[0, 1] = matrix[row][col + 1];
                    bestResultMatrix[1, 1] = matrix[row+ +1 ][col+ + 1];                
                }
            }
        }

        int count = 1;
        foreach (var arr in bestResultMatrix)
        {
            Console.Write($"{arr} ");
            if(count % 2 == 0)
            {
                Console.WriteLine();
            }

            count++;
        }

        Console.WriteLine(bestResult);
    }
}