using System;
using System.Collections.Generic;
using System.Linq;


public class WeakStudents
{
    public static void Main(string[] args)
    {
        var students = new Dictionary<string, List<int>>();

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
            var grades = tokens.Skip(2).Select(int.Parse).Where(x => x == 2 || x == 3).ToList();

            students.Add(name, grades);
        }

        foreach (var student in students.Where(x => x.Value.Count() >= 2))
        {
            Console.WriteLine(student.Key);
        }
    }
}
