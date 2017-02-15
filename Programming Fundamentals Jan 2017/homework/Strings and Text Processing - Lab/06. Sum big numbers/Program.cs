namespace _06.Sum_big_numbers
{
    using System;
    using System.Collections.Generic;

    public class SumBigNumbers
    {
        public static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string helper;

            if (str1.Length < str2.Length)
            {
                helper = str1;
                str1 = str2;
                str2 = helper;
            }

            List<int> result = new List<int>();
            str2 = str2.PadLeft(str1.Length, '0');

            for (int i = str1.Length - 1; i >= 0; i--)
            {
                int a = Convert.ToInt32(char.GetNumericValue(str1[i]));
                int b = Convert.ToInt32(char.GetNumericValue(str2[i]));
                result.Add(a + b);
            }

            result.Reverse();
            for (int i = result.Count - 1; i >= 1; i--)
            {
                if (!(result[i] / 10 == 0))
                {
                    result[i - 1] += result[i] / 10;
                    result[i] = result[i] % 10;
                }
            }

            string trimResult = string.Join(string.Empty, result);
            trimResult = trimResult.TrimStart('0');
            Console.WriteLine(trimResult);
        }
    }
}