using System;
using System.Collections.Generic;
using System.Linq;

public static class StudentsByAge
{
    public static void Main()
    {
        var students = new List<string>();

        while (true)
        {
            var input = Console.ReadLine().Trim();

            if (input == "END")
            {
                break;
            }

            students.Add(input);
        }

        foreach (var student in students)
        {
            var tokens = student
                .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var age = int.Parse(tokens[2]);

            if (age >= 18 && age <= 24)
            {
                Console.WriteLine(student);
            }
        }
    }
}