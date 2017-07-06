using System;
using System.Collections.Generic;
using System.Linq;

public static class AppliedArithmetics
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Commands(input);
    }

    public static List<string> Commands(int[] input)
    {
        var commands = new List<string>();

        while (true)
        {
            var command = Console.ReadLine();

            if (command == "end")
            {
                break;
            }

            switch (command)
            {
                case "add":
                    Add(input);
                    break;

                case "subtract":
                    Substact(input);
                    break;

                case "multiply":
                    Multiply(input);
                    break;

                case "print":
                    Console.WriteLine(string.Join(" ", input));
                    break;
            }
        }

        return commands;
    }

    public static void Add(int[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            input[i] += 1;
        }
    }

    public static void Substact(int[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            input[i] -= 1;
        }
    }

    public static void Multiply(int[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            input[i] *= 2;
        }
    }
}