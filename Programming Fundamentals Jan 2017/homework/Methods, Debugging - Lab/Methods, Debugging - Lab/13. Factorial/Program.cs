namespace _13.Factorial
{
    using System;
    using System.Numerics;

    public class FactorialNumber
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorialResult = Factorial(n);

            int count = 0;

            for (int i = 5; factorialResult / i >= 1; i *= 5)
            {
                count += n / i;
            }

            Console.WriteLine(count);
        }

        public static BigInteger Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
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
}