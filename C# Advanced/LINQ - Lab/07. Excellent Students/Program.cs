using System;
using System.Collections.Generic;
using System.Linq;

public class ExcellentStudents
{
    public static void Main(string[] args)
    {
        var students = new Dictionary<string, string[]>();

        while (true)
        {
            var input = Console.ReadLine();

            if (input == "END")
            {
                break;
            }

            var tokens = input
                .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var name = $"{tokens[0]} {tokens[1]}";
            var grades = tokens.Skip(2).ToArray();

            students.Add(name, grades);
        }

        foreach (var student in students.Where(x => x.Value.Contains("6")))
        {
            Console.WriteLine(student.Key);
        }
    }
}