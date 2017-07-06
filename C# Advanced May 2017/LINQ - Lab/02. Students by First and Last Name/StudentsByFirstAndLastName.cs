using System;
using System.Collections.Generic;
using System.Linq;

public class StudentsByFirstAndLastName
{
    public static void Main(string[] args)
    {
        var result = new List<string[]>();
        while (true)
        {
            var input = Console.ReadLine().Trim();

            if (input == "END")
            {
                break;
            }

            result.Add(input
                .Split(new char[] {}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray());
        }

        foreach (var name in result.Where(x => string.Compare(x[0], x[1]) < 0))
        {
            Console.WriteLine(string.Join(" ", name));
        }
            
    }
}