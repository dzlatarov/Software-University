using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class RubiksCube
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

        int numberOfCommands = int.Parse(Console.ReadLine());

        var commands = new List<string[]>();

        for(int i = 0; i < numberOfCommands; i++)
        {
            commands.Add(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray());
        }

        int counter = 1;

        for(int x = 0; x < matrixHeight; x++)
        {
            for(int y = 0; y < matrixWidth; y++)
            {
                if(matrix[x][y] != counter)
                {

                }
            }
        }
    }
}

