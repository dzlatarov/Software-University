namespace _06.PrimeChecker
{
    using System;

    public class PrimeChecker
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(CheckForPrime(number));
        }

        public static bool CheckForPrime(long number)
        {
            if (number == 1)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }
            else if (number % 2 == 0)
            {
                return false;
            }

            long boundary = (long)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}