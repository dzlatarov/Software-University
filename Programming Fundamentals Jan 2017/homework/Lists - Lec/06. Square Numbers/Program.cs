namespace _06.Square_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> squareNumbers = new List<int>();

            foreach (int x in numbers)
            {
                if (Math.Sqrt(x) % 1 == 0)
                {
                    squareNumbers.Add(x);
                }
            }

            squareNumbers.Sort();
            squareNumbers.Reverse();
            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
