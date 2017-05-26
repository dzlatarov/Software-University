using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

public class CountSameValuesInArray
{
    public static void Main(string[] args)
    {
        double[] input = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        var repeatingNumbersCount = new SortedDictionary<double, double>();

        double[] distincInput = input.Distinct().ToArray();

        foreach(double d in distincInput)
        {
            repeatingNumbersCount.Add(d, input.Count(x => x == d));
        }

        NumberFormatInfo nfi = new NumberFormatInfo();
        nfi.NumberDecimalSeparator = ",";
        foreach(var kvp in repeatingNumbersCount)
        {
            Console.WriteLine($"{kvp.Key.ToString(nfi)} - {kvp.Value.ToString(nfi)} times");
        }
    }
}