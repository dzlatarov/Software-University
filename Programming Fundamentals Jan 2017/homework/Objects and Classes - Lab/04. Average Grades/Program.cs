namespace _04.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> studentsAndGrades = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();

                string name = input[0];

                studentsAndGrades[i].Name = name;
                
                for(int x = 1; x < n; x++)
                {
                    studentsAndGrades[i].Grades.Add(Convert.ToDouble(input[x]));
                }                       
            }        
        }
    }
}
