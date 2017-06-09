namespace _03.Big_Factorial
{
    using System;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            BigInteger output = 1;

            for (int i = 1; i <= input; i++)
            {
                output *= i;
            }

            Console.WriteLine(output);
        }
    }
}