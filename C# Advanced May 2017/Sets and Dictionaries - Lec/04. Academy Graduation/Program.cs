using System;
using System.Collections.Generic;
using System.Linq;

public class AcademyGraduation
{
    public static void Main(string[] args)
    {
        int numberOfStudents = int.Parse(Console.ReadLine());
        var studentsAndGrades = new SortedDictionary<string, double>();

        for(int i = 0; i < numberOfStudents; i++)
        {
            string studentName = Console.ReadLine();

            double[] studentGrades = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            double averageGrade = studentGrades.Average();

            studentsAndGrades.Add(studentName, averageGrade);
        }

        foreach(var kvp in studentsAndGrades)
        {
            Console.WriteLine($"{kvp.Key} is graduated with {kvp.Value}");
        }
    }
}