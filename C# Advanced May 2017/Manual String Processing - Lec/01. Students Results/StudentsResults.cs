using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StudentsResults
{
    public static void Main(string[] args)
    {
        int numberOfInputs = int.Parse(Console.ReadLine());

        var studentGrades = new Dictionary<string, double[]>();
        for (int i = 0; i < numberOfInputs; i++)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string student = input[0].Trim();
            double grade1 = double.Parse(input[1].Trim());
            double grade2 = double.Parse(input[2].Trim());
            double grade3 = double.Parse(input[3].Trim());
            double averageGrade = (grade1 + grade2 + grade3) / 3d;


            var grades = new double[] { grade1, grade2, grade3, averageGrade };

            studentGrades.Add(student, grades);
        }

        Console.WriteLine(string.Format("{0, -10}|{1,7}|{2,7}|{3,7}|{4,7}|", "Name", "CAdv", "COOP", "AdvOOP", "Average"));

        foreach(var kvp in studentGrades)
        {
            Console.WriteLine(string.Format("{0, -10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|", kvp.Key, kvp.Value[0], kvp.Value[1], kvp.Value[2], kvp.Value[3]));
        }
    }
}