using System;
using System.Numerics;

public static class SumBigNumbers
{
    public static void Main(string[] args)
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());

        BigInteger result = a + b;

        Console.WriteLine(result);
    }
}