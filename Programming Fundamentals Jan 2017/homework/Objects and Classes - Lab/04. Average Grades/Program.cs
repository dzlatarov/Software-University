namespace _04.Average_Grades
{
    using System;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Students[] students = new Students[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                string name = input[0];

                double[] grades = new double[input.Length - 1];
                for (int k = 1; k < input.Length; k++)
                {
                    grades[k - 1] = Convert.ToDouble(input[k]);
                }

                students[i] = new Students
                {
                    Name = name,
                    Grades = grades
                };
            }

            foreach (Students student in students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).Where(x => x.AverageGrade >= 5))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }
    }
}