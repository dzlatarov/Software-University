namespace _05.Closest_Two_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ClosestTwoPoints
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Points[] points = new Points[n];

            for (int i = 0; i < n; i++)
            {
                int[] inputSplit = Console.ReadLine().Split().Select(int.Parse).ToArray();

                points[i] = new Points()
                {
                    X = inputSplit[0],
                    Y = inputSplit[1]
                };
            }

            List<DistanceBetweenPoints> distanceBetweenPoints = FindDistanceBetweenPoints(points);

            double distance = distanceBetweenPoints[0].Distance;
            for (int i = 1; i < distanceBetweenPoints.Count(); i++)
            {
                if (distance > distanceBetweenPoints[i].Distance)
                {
                    distance = distanceBetweenPoints[i].Distance;
                }
            }

            for (int i = distanceBetweenPoints.Count() - 1; i >= 0; i--)
            {
                if (distance == distanceBetweenPoints[i].Distance)
                {
                    int indexOfLowestDistance = i;
                    Console.WriteLine("{0:F3}", distanceBetweenPoints[indexOfLowestDistance].Distance);
                    Console.WriteLine("{0}", distanceBetweenPoints[indexOfLowestDistance].PointTwoC);
                    Console.WriteLine("{0}", distanceBetweenPoints[indexOfLowestDistance].PointOneC);
                    break;
                }
            }
        }

        public static List<DistanceBetweenPoints> FindDistanceBetweenPoints(Points[] points)
        {
            List<DistanceBetweenPoints> distanceBetweenPoins = new List<DistanceBetweenPoints>();

            for (int i = points.Count() - 1; i >= 0; i--)
            {
                for (int x = 0; x < i; x++)
                {
                    int a = Math.Abs(points[i].X - points[x].X);
                    int b = Math.Abs(points[i].Y - points[x].Y);
                    double result = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    distanceBetweenPoins.Add(new DistanceBetweenPoints()
                    {
                        Distance = result,
                        PointOneC = $"({points[i].X}, {points[i].Y})",
                        PointTwoC = $"({points[x].X}, {points[x].Y})"
                    });
                }
            }

            return distanceBetweenPoins;
        }
    }
}