namespace _08._8.CenterPoint
{
    using System;

    public class CenterPoint
    {
        public static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            string result = CenterPointCompare(X1, Y1, X2, Y2);
            Console.WriteLine(result);
        }

        public static string CenterPointCompare(double X1, double Y1, double X2, double Y2)
        {
            if (Math.Abs(Math.Sqrt(X1*X1 + Y1*Y1)) > Math.Abs(Math.Sqrt(X2*X2 + Y2*Y2)))
            {
                return string.Format("({0}, {1})", X2, Y2);
            }
            else
            {
                return string.Format("({0}, {1})", X1, Y1);
            }
        }
    }
}