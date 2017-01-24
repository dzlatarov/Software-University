namespace DrawFilledSquare
{
    using System;

    public class FilledSquare
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            TopAndBottomSquare(size);
            SquareFill(size);
            TopAndBottomSquare(size);
        }

        public static void TopAndBottomSquare(int size)
        {
            Console.WriteLine(new string('-', 2 * size));
        }

        public static void SquareFill(int size)
        {
            string lines = string.Empty;

            for (int i = 1; i < size; i++)
            {
                lines = lines + "\\/";
            }

            for (int i = 0; i < size - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", "-", lines);
            }
        }
    }
}
