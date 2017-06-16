using System;
using System.Collections.Generic;
using System.Linq;

public static class FilterStudentsByEmailDomain
{
    public static void Main(string[] args)
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

        foreach (var student in students.Where(x => x.EndsWith("gmail.com")))
        {
            Console.WriteLine(String.Join(" ", student.Split().Take(2).ToArray()));
        }
    }
}