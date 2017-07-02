using System;
using System.Collections.Generic;
using System.Linq;

public static class StudentsJoinedToSpecialties
{
    public static void Main(string[] args)
    {
        var studentProf = new List<string>();
        var studentName = new List<string>();
        while (true)
        {
            var inputProf = Console.ReadLine().Trim();

            if (inputProf == "Students:")
            {
                while (true)
                {
                    var inputName = Console.ReadLine().Trim();

                    if (inputName == "END")
                    {
                        break;
                    }

                    studentName.Add(inputName);
                }

                break;
            }

            studentProf.Add(inputProf);
        }

        var result = new List<string[]>();

        foreach (var name in studentName)
        {
            var tokens = name.Split(new char[] { }, 2, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var personName = tokens[1];
            var numberName = tokens[0];

            foreach (var job in studentProf)
            {
                var tokens2 = job.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var personJob = $"{tokens2[0]} {tokens2[1]}";
                var numberJob = tokens2[2];

                if (numberName == numberJob)
                {
                    result.Add($"{personName} {numberName} {personJob}".Split(' ').ToArray());
                }
            }
        }

        foreach (var arr in result.OrderBy(x => x[0]))
        {
            Console.WriteLine($"{arr[0]} {arr[1]} {arr[2]} {arr[3]} {arr[4]}");
        }
    }
}