using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class FindAndSumInts
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();

        var filter = new Regex(@"^-?\d+(\.\d+)?$");
        var sum = input
            .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
            .Where(x => filter.IsMatch(x))
            .ToList();

        if (sum.Count == 0)
        {
            Console.WriteLine("No match");
        }
        else
        {
            Console.WriteLine(sum.Select(x => double.Parse(x)).Sum());
        }       
    }
}