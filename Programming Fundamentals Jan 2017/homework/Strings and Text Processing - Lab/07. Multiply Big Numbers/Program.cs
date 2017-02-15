namespace _07.Multiply_Big_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class MultiplyBigNumbers
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

            str1 = str1.TrimStart('0');
            str2 = str2.TrimStart('0');

            List<string> result = new List<string>();
            str2 = str2.PadLeft(str1.Length, '0');

            int count = 0;
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                List<int> temp = new List<int>();
                for (int k = str2.Length - 1; k >= 0; k--)
                {
                    int a = Convert.ToInt32(char.GetNumericValue(str1[i]));
                    int b = Convert.ToInt32(char.GetNumericValue(str2[k]));

                    temp.Add(a * b);
                }

                temp.Reverse();
                for (int x = temp.Count - 1; x > 0; x--)
                {
                    if (!(temp[x] / 10 == 0))
                    {
                        temp[x - 1] += temp[x] / 10;
                        temp[x] = temp[x] % 10;
                    }
                }

                string trimTemp = string.Join(string.Empty, temp);
                trimTemp = trimTemp.PadRight(trimTemp.Length + count, '0');
                trimTemp = trimTemp.TrimStart('0');
                count++;

                result.Add(trimTemp);
            }

            result.RemoveAll(x => x == string.Empty);

            BigInteger sum = 0;
            foreach(string str in result)
            {
                sum += BigInteger.Parse(str);
            }

            Console.WriteLine(sum);
        }
    }
}