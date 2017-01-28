namespace _02.Rotate_and_Sum
{
    using System;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int timesRotated = int.Parse(Console.ReadLine());

            int[] sum = new int[data.Length];

            for (int r = 0; r < timesRotated; r++)
            {
                int lastNum = data[data.Length - 1];
                for (int i = data.Length - 1; i > 0; i--)
                {
                    data[i] = data[i - 1];
                }

                data[0] = lastNum;

                for (int i = 0; i < data.Length; i++)
                {
                    sum[i] += data[i];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}