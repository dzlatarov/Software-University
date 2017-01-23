namespace _5.CalculateTriangleArea
{
    using System;

    public class TriangleArea
    {
        public static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(width, height);
            Console.WriteLine(area);
        }

        public static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
