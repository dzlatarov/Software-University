namespace _09.LongerLine
{
    using System;

    public class LongerLine
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DistanceCompare());
        }

        public static double LineLengthOne(double xOne1, double xOne2, double yOne1, double yOne2)
        {
            double distanceOne = Math.Sqrt(Math.Pow(Math.Abs(xOne1 - xOne2), 2) + Math.Pow(Math.Abs(yOne1 - yOne2), 2));
            return distanceOne;
        }

        public static double LineLengthTwo(double xTwo1, double xTwo2, double yTwo1, double yTwo2)
        {
            double distanceTwo = Math.Sqrt(Math.Pow(Math.Abs(xTwo1 - xTwo2), 2) + Math.Pow(Math.Abs(yTwo1 - yTwo2), 2));
            return distanceTwo;
        }

        public static string DistanceCompare()
        {
            double xOne1 = double.Parse(Console.ReadLine());
            double xOne2 = double.Parse(Console.ReadLine());
            double yOne1 = double.Parse(Console.ReadLine());
            double yOne2 = double.Parse(Console.ReadLine());
            double xTwo1 = double.Parse(Console.ReadLine());
            double xTwo2 = double.Parse(Console.ReadLine());
            double yTwo1 = double.Parse(Console.ReadLine());
            double yTwo2 = double.Parse(Console.ReadLine());

            double distanceOne = LineLengthOne(xOne1, xOne2, yOne1, yOne2);
            double distanceTwo = LineLengthTwo(xTwo1, xTwo2, yTwo1, yTwo2);

            if (distanceOne >= distanceTwo)
            {
                if (Math.Abs(Math.Sqrt(xOne1 * xOne1 + yOne1 * yOne1)) < Math.Abs(Math.Sqrt(xOne2 * xOne2 + yOne2 * yOne2)))
                {
                    return string.Format("({0}, {1})({2}, {3}", xOne1, xOne2, yOne1, yOne2);
                }
                else if (Math.Abs(Math.Sqrt(xOne1 * xOne1 + yOne1 * yOne1)) > Math.Abs(Math.Sqrt(xOne2 * xOne2 + yOne2 * yOne2)))
                {
                    return string.Format("({2}, {3})({0}, {1}", xOne1, xOne2, yOne1, yOne2);
                }
                else
                {
                    return string.Format("({0}, {1})", xOne1, xOne2);
                }
            }
            else
            {
                if (Math.Abs(Math.Sqrt(xTwo1 * xTwo1 + yTwo1 * yTwo1)) < Math.Abs(Math.Sqrt(xTwo2 * xTwo2 + yTwo2 * yTwo2)))
                {
                    return string.Format("({0}, {1})({2}, {3}", xTwo1, xTwo2, yTwo1, yTwo2);
                }
                else if (Math.Abs(Math.Sqrt(xTwo1 * xTwo1 + yTwo1 * yTwo1)) > Math.Abs(Math.Sqrt(xTwo2 * xTwo2 + yTwo2 * yTwo2)))
                {
                    return string.Format("({2}, {3})({0}, {1})", xTwo1, xTwo2, yTwo1, yTwo2);
                }
                else
                {
                    return string.Format("({0}, {1})", xTwo1, xTwo2);
                }
            }
        }
    }
}