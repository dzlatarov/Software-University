using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LegoBlocks
{
    public static void Main(string[] args)
    {
        int numberOfRowsInEachArray = int.Parse(Console.ReadLine());

        var arrayOne = new int[numberOfRowsInEachArray][];
        var arrayTwo = new int[numberOfRowsInEachArray][];

        int totalNumberOfCells = 0;

        for (int i = 0; i < numberOfRowsInEachArray; i++)
        {
            arrayOne[i] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            totalNumberOfCells += arrayOne[i].Length;
        }

        for (int i = 0; i < numberOfRowsInEachArray; i++)
        {
            arrayTwo[i] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).Reverse().ToArray();

            totalNumberOfCells += arrayTwo[i].Length;
        }

        var mergedArray = MergeArray(numberOfRowsInEachArray, arrayOne, arrayTwo);

        if (FitsPerfectly(mergedArray, numberOfRowsInEachArray))
        {
            foreach (int[] row in mergedArray)
            {
                Console.WriteLine("[{0}]", string.Join(", ", row));
            }
        }
        else
        {
            Console.WriteLine($"The total number of cells is: {totalNumberOfCells}");
        }
    }

    public static int[][] MergeArray(int rows, int[][] arrayOne, int[][] arrayTwo)
    {
        var mergeArray = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            List<int> mergedRow = new List<int>();

            mergedRow.AddRange(arrayOne[i]);
            mergedRow.AddRange(arrayTwo[i]);

            mergeArray[i] = mergedRow.ToArray();
        }

        return mergeArray;
    }

    public static bool FitsPerfectly(int[][] mergedArray, int rows)
    {
        bool fitsPerfectly = true;

        int length = mergedArray[0].Length;

        for (int i = 1; i < rows; i++)
        {
            if (length != mergedArray[i].Length)
            {
                fitsPerfectly = false;
                break;
            }
        }

        return fitsPerfectly;
    }
}