using System;
using System.Linq;
using System.Text;
using System.Numerics;


public static class ConvertFromVase10ToBaseN
{
    public static void Main(string[] args)
    {
        BigInteger[] input = Console.ReadLine()
            .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(BigInteger.Parse)
            .ToArray();

        BigInteger decimalNumber = input[0];
        BigInteger baseNumber = input[1];
        var remainders = new StringBuilder();

        while (baseNumber > 0)
        {
            BigInteger remainder = baseNumber % decimalNumber;

            baseNumber = baseNumber / decimalNumber;

            remainders.Append(remainder);
        }

        char[] result = remainders.ToString().ToCharArray().Reverse().ToArray();

        Console.WriteLine(result);
    }
}