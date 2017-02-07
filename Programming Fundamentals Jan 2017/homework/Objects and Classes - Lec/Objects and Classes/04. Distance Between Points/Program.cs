namespace _04.Distance_Between_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        public static void Main(string[] args)
        {
            List<int> pointOneC = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> pointTwoC = Console.ReadLine().Split().Select(int.Parse).ToList();

            Point pointOne = new Point()
            { X = pointOneC[0], Y = pointOneC[1] };
            Point pointTwo = new Point()
            { X = pointTwoC[0], Y = pointTwoC[1] };

            double result = CalcDistance(pointOne, pointTwo);
            Console.WriteLine("{0:F3}", result);
        }

        public static double CalcDistance(Point pointOne, Point pointTwo)
        {
            double a = Math.Abs(pointOne.X - pointTwo.X);
            double b = Math.Abs(pointOne.Y - pointTwo.Y);
            double result = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return result;
        }
    }
}