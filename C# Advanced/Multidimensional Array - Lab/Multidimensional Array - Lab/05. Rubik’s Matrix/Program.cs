using System;
using System.Collections.Generic;
using System.Linq;

public static class RubiksMatrix
{
    public static void Main(string[] args)
    {
        string[] matrixDimensions = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        int matrixHeight = int.Parse(matrixDimensions[0]);
        int matrixWidth = int.Parse(matrixDimensions[1]);

        var matrix = MatrixWithValues(matrixHeight, matrixWidth);
        var commands = Commands();
        MatrixAfterCommands(matrixHeight, matrixWidth, matrix, commands);

        foreach (var result in Result(matrixHeight, matrixWidth, matrix))
        {
            Console.WriteLine(result);
        }
    }

    public static int[,] MatrixWithValues(int matrixHeight, int matrixWidth)
    {
        int[,] matrix = new int[matrixHeight, matrixWidth];

        int counter = 1;
        for (int x = 0; x < matrixHeight; x++)
        {
            for (int y = 0; y < matrixWidth; y++)
            {
                matrix[x, y] = counter;

                counter++;
            }
        }

        return matrix;
    }

    public static string[][] Commands()
    {
        int numberOfCommands = int.Parse(Console.ReadLine());

        var commands = new string[numberOfCommands][];

        for (int i = 0; i < numberOfCommands; i++)
        {
            commands[i] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        return commands;
    }

    public static int[,] MatrixAfterCommands(int matrixHeight, int matrixWidth, int[,] matrix, string[][] commands)
    {
        foreach (var command in commands)
        {
            int rotateLocation = int.Parse(command[0]);
            string commandName = command[1];
            int rotateTimes = int.Parse(command[2]);



            switch (commandName)
            {
                case "up":
                    var queueUp = new Queue<int>();
                    for (int i = 0; i < matrixHeight; i++)
                    {
                        queueUp.Enqueue(matrix[i, rotateLocation]);
                    }

                    for (int i = 0; i < rotateTimes % matrixHeight; i++)
                    {
                        queueUp.Enqueue(queueUp.Dequeue());
                    }

                    for (int i = 0; i < matrixHeight; i++)
                    {
                        matrix[i, rotateLocation] = queueUp.Dequeue();
                    }
                    break;

                case "down":
                    var queueDown = new Queue<int>();
                    for (int i = matrixHeight - 1; i >= 0; i--)
                    {
                        queueDown.Enqueue(matrix[i, rotateLocation]);
                    }

                    for (int i = 0; i < rotateTimes % matrixHeight; i++)
                    {
                        queueDown.Enqueue(queueDown.Dequeue());
                    }

                    for (int i = matrixHeight - 1; i >= 0; i--)
                    {
                        matrix[i, rotateLocation] = queueDown.Dequeue();
                    }
                    break;

                case "left":
                    var queueLeft = new Queue<int>();
                    for (int i = 0; i < matrixHeight; i++)
                    {
                        queueLeft.Enqueue(matrix[rotateLocation, i]);
                    }

                    for (int i = 0; i < rotateTimes % matrixWidth; i++)
                    {
                        queueLeft.Enqueue(queueLeft.Dequeue());
                    }

                    for (int i = 0; i < matrixHeight; i++)
                    {
                        matrix[rotateLocation, i] = queueLeft.Dequeue();
                    }
                    break;

                case "right":
                    var queueRight = new Queue<int>();
                    for (int i = matrixHeight - 1; i >= 0; i--)
                    {
                        queueRight.Enqueue(matrix[rotateLocation, i]);
                    }

                    for (int i = 0; i < rotateTimes % matrixWidth; i++)
                    {
                        queueRight.Enqueue(queueRight.Dequeue());
                    }

                    for (int i = matrixHeight - 1; i >= 0; i--)
                    {
                        matrix[rotateLocation, i] = queueRight.Dequeue();
                    }
                    break;
            }
        }

        return matrix;
    }

    public static List<string> Result(int matrixHeight, int matrixWidth, int[,] matrix)
    {
        var result = new List<string>();

        int counter = 1;
        for (int x = 0; x < matrixHeight; x++)
        {
            for (int y = 0; y < matrixWidth; y++)
            {
                if (matrix[x, y] != counter)
                {
                    int firstVariable = matrix[x, y];

                    for (int k = 0; k < matrixHeight; k++)
                    {
                        for (int i = 0; i < matrixWidth; i++)
                        {
                            if (matrix[k, i] == counter)
                            {
                                matrix[x, y] = matrix[k, i];

                                matrix[k, i] = firstVariable;

                                result.Add($"Swap ({x}, {y}) with ({k}, {i})");
                            }
                        }
                    }
                }
                else
                {
                    result.Add("No swap required");
                }

                counter++;
            }
        }

        return result;
    }
}