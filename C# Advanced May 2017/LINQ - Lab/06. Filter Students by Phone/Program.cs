using System;
using System.Collections.Generic;
using System.Linq;

public static class FilterStudentsByPhone
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

            students
                .Add(input
                .Split(new char[] {}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray());
        }

        foreach (var student in students.Where(x => x[2].StartsWith("02") || x[2].StartsWith("+3592")))
        {
            Console.WriteLine($"{student[0]} {student[1]}");
        }
    }
}