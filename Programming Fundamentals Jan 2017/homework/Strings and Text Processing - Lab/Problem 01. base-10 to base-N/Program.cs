namespace Problem_01.base_10_to_base_N
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class BaseTenToBaseN
    {
        public static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            BigInteger n = input[1];
            BigInteger nBase = input[0];

            List<BigInteger> result = new List<BigInteger>();
            while (n != 0)
            {
                result.Add(n % nBase);
                n = n / nBase;
            }

            result.Reverse();
            Console.WriteLine(string.Join(string.Empty, result));
        }
    }
}