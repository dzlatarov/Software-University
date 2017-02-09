
namespace _04.Average_Grades
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Collections.Generic;

    public class AverageGrades
    {
        public static void Main(string[] args)
        {
            string[] inputTxt = File.ReadAllLines("input.txt");

            int n = int.Parse(inputTxt[0]);

            Students[] students = new Students[n];

            for (int i = 1; i <= n; i++)
            {
                string[] input = inputTxt[i].Split(' ').ToArray();

                string name = input[0];

                double[] grades = new double[input.Length - 1];
                for (int k = 1; k < input.Length; k++)
                {
                    grades[k - 1] = Convert.ToDouble(input[k]);
                }

                students[i - 1] = new Students
                {
                    Name = name,
                    Grades = grades
                };
            }

            List<string> output = new List<string>();
            foreach (Students student in students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).Where(x => x.AverageGrade >= 5))
            {
                output.Add($"{student.Name} -> {student.AverageGrade:F2}");
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}