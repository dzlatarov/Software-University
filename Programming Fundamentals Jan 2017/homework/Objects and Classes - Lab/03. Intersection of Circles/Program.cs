namespace _03.Intersection_of_Circles
{
    using System;
    using System.Linq;

    public class IntersectionOfCircles
    {
        public static void Main(string[] args)
        {
            int[] circleOneProperties = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] circleTwoProperties = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Circle circleOne = new Circle()
            {
                X = circleOneProperties[0],
                Y = circleOneProperties[1],
                R = circleOneProperties[2]
            };

            Circle circleTwo = new Circle()
            {
                X = circleTwoProperties[0],
                Y = circleTwoProperties[1],
                R = circleTwoProperties[2]
            };

            string result = CirclesIntersect(circleOne, circleTwo) ? "Yes" : "No";

            Console.WriteLine(result);
        }

        public static bool CirclesIntersect(Circle circleOne, Circle circleTwo)
        {
            double a = Math.Abs(circleOne.X - circleTwo.X);
            double b = Math.Abs(circleOne.Y - circleTwo.Y);
            double d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            if (d <= circleOne.R + circleTwo.R)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}