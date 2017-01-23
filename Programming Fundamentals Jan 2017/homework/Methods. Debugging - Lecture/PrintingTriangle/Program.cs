namespace PrintingTriangle
{
    using System;

    public class PrintingTriangle
    {
        public static void Main(string[] args)
        {
            PrintTriangle();
        }

        public static void PrintFirstHalfAndMiddle(int size)
        {
            for (int x = 1; x <= size; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write($"{y} ");
                }

                Console.WriteLine();
            }
        }

        public static void PrintSecondHalf(int size)
        {
            for (int x = size; x >= 1; x--)
            {
                for (int y = 1; y < x; y++)
                {
                    Console.Write($"{y} ");
                }

                Console.WriteLine();
            }
        }

        public static void PrintTriangle()
        {
            int size = int.Parse(Console.ReadLine());
            PrintFirstHalfAndMiddle(size);
            PrintSecondHalf(size);
        }
    }
}