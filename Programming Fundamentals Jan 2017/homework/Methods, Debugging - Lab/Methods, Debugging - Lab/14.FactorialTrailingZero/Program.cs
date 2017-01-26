namespace _14.FactorialTrailingZero
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorialResult = Factorial(n);

            int count = 0;
            for (int i = 5; n / i >= 1; i *= 5)
            {
                count += n / i;
            }

            Console.WriteLine(count);
        }

        public static BigInteger Factorial(int n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
