namespace _6.MathPower
{
    using System;

    public class MathPower
    {
        public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

        public static double RaiseToPower(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
