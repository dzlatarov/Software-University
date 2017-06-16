using System;
using System.Collections.Generic;
using System.Linq;

public static class SortStudents
{
    public static void Main(string[] args)
    {
        var students = new List<string[]>();

        while (true)
        {
            var input = Console.ReadLine().Trim();

            if (input == "END")
            {
                break;
            }

            students.Add(input
                .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray());
        }

        foreach (var student in students.OrderBy(x => x[1]).ThenByDescending(x => x[0]))
        {
            Console.WriteLine(string.Join(" ", student));
        }
    }
}