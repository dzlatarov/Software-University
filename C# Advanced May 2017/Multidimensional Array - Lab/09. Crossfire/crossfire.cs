using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossfire
{
    public class Crossfire
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var rows = dimensions[0];
            var cols = dimensions[1];

            var matrix = new int[rows][];
            var count = 1;

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];

                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = count++;
                }
            }

            var input = Console.ReadLine();

            while (input != "Nuke it from orbit")
            {
                var args = input
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                var row = args[0];
                var col = args[1];
                var radius = args[2];

                for (int i = row - radius; i <= row + radius; i++)
                {
                    //if (i == Array.FindIndex(matrix, x => x.Count() == 0))
                    //    continue;

                    if (IsInMatrix(matrix, i, col))
                    {
                        matrix[i][col] = -1;
                    }
                }

                for (int i = col - radius; i <= col + radius; i++)
                {
                    //if (row == Array.FindIndex(matrix, x => x.Count() == 0))
                    //    break;

                    if (IsInMatrix(matrix, row, i))
                    {
                        matrix[row][i] = -1;
                    }
                }

                matrix = filterMatrix(matrix);

                input = Console.ReadLine();
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                var line = string.Join(" ", matrix[i]);
                if (line.Length == 0)
                    continue;

                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }

        private static bool IsInMatrix(int[][] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;
        }

        private static int[][] filterMatrix(int[][] matrix)
        {
            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    matrix[i] = matrix[i]
            //        .Where(j => j > -1)
            //        .ToArray();
            //}

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    if (matrix[rowIndex][colIndex] < 0)
                    {
                        matrix[rowIndex] = matrix[rowIndex].Where(n => n != -1).ToArray();
                    }
                }

                if (matrix[rowIndex].Length < 1)
                {
                    matrix = matrix.Take(rowIndex).Concat(matrix.Skip(rowIndex + 1)).ToArray();
                    rowIndex--;
                }
            }

            return matrix;

            //var a = Array.FindIndex(matrix, x => x.Count() == 0);
            //matrix = matrix
            //    .Where((arr, i) => i != a)
            //    .ToArray();
            //Console.WriteLine("Empty Row Index {0}", a);
        }
    }
}