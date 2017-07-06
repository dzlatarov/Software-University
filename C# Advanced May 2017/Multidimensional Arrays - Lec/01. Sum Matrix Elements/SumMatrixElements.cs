using System;
using System.Linq;

public class SumMatrixElements
{
    public static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int x = input[0];
        int y = input[1];

        int[][] matrix = new int[x][];

        for(int rows = 0; rows < x; rows++)
        {
            matrix[rows] = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        Console.WriteLine(x);
        Console.WriteLine(y);

        int sum = 0;

        foreach(var number in matrix)
        {
            sum += number.Sum();
        }

        Console.WriteLine(sum);
    }
}