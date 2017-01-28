namespace _04.Sieve_of_Eratosthenes
{
    using System;

    public class SieveOfEratosthenes
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] primeIsTrue = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                primeIsTrue[i] = true;
            }

            for (int i = 0; i <= n; i++)
            {
                if (primeIsTrue[i])
                {
                    for (int p = 2; (p * i) <= n; p++)
                    {
                        primeIsTrue[p * i] = false;
                    }
                }
            }

            for (int i = 0; i <= n; i++)
            {
                if (primeIsTrue[i])
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}