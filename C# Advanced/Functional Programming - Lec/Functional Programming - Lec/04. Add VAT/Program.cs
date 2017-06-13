using System;
using System.Linq;

public static class addVAT
{
    public static void Main(string[] args)
    {
        double[] input = Console.ReadLine()
            .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse).Select(x => x * 1.2)
            .ToArray();

        foreach (var numberAfterVAT in input)
        {
            Console.WriteLine($"{numberAfterVAT:0.00}");
        }
    }
}