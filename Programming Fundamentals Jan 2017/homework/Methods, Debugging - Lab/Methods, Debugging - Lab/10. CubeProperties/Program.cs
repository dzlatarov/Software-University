namespace _10.CubeProperties
{
    using System;

    public class CubeProperties
    {
        public static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string calculateWhat = Console.ReadLine();
            double result = CalculateCubesProperties(side, calculateWhat);

            Console.WriteLine("{0:0.00}", result);
        }

        public static double CalculateCubesProperties(double side, string calculateWhat)
        {
            double result = 0;
            switch (calculateWhat)
            {
                case "face":
                    result = side * Math.Sqrt(2);
                    break;

                case "space":
                    result = side * Math.Sqrt(3);
                    break;

                case "volume":
                    result = Math.Pow(side, 3);
                    break;

                case "area":
                    result = 6 * Math.Pow(side, 2);
                    break;

                default:
                    return result;
            }

            return result;
        }
    }
}