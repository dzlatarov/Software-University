namespace _02.Convert_from_base_N_to_base_10
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class ConvertFromBaseNToBaseTen
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int nBase = Convert.ToInt32(input[0]);
            string n = input[1];

            BigInteger result = 0;
            BigInteger index = 1;
            foreach (char c in n.Reverse())
            {
                int val = (int)Char.GetNumericValue(c);
                result += val * index;
                index *= nBase;
            }

            Console.WriteLine(result);
        }
    }
}