namespace _02.MaxMethod
{
    using System;
    using System.Linq;

    public class MaxMethod
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = GetMax(a, b, c);
            Console.WriteLine(result);
        }

        public static int GetMax(int a, int b, int c)
        {
            int[] maxValue = new int[3];
            maxValue[0] = a;
            maxValue[1] = b;
            maxValue[2] = c;

            return maxValue.Max();
        }
    }
}