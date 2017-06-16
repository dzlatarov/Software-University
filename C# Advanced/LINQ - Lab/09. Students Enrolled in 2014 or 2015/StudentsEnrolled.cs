using System;
using System.Collections.Generic;
using System.Linq;

public class StudentsEnrolled
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

            students.Add(input.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray());
        }

        foreach (var student in students.Where(x => x[0].EndsWith("14") || x[0].EndsWith("15")))
        {
            Console.WriteLine(string.Join(" ", student.Skip(1)));
        }
    }
}