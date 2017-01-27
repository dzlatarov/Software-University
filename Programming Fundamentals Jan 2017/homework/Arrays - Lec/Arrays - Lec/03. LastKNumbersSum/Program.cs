namespace _03.LastKNumbersSum
{
    using System;

    public class LastKNumberSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long sum = 0;

            long[] array = new long[n];
            array[0] = 1;

            for (int i = 1; i < n; i++)
            {
                if (i - k <= 0)
                {
                    foreach (long p in array)
                    {
                        sum += p;
                    }

                    array[i] = sum;
                    sum = 0;
                }
                else
                {
                    for (int z = i; z >= i - k; z--)
                    {
                        sum += array[z];
                    }

                    array[i] = sum;
                    sum = 0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}