namespace _04.Average_Grades
{
    using System.Linq;

    public class Students
    {
        public string Name { get; set; }

        public double[] Grades { get; set; }

        public double AverageGrade
        {
            get
            { 
                return this.Grades.Average();
            }
        }
    }
}
