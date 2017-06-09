namespace _05.FibonaciiNumbers
{
    using System;

    public class NthFibNumber
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FibNumberNth(n));
        }

        public static double FibNumberNth(int n)
        {
            n = n + 1;
            double phi = (Math.Sqrt(5) + 1) / 2;

            long fibNth = (long)((Math.Pow(phi, n) - Math.Pow(-phi, -n)) / Math.Sqrt(5));

            return fibNth;
        }
    }
}