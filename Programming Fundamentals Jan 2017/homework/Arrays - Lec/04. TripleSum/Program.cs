namespace _04.TripleSum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string[] array = n.Split(' ');

            int[] integerArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                integerArray[i] = Convert.ToInt32(array[i]);
            }

            bool contains = true;
            for (int x = 0; x < integerArray.Length; x++)
            {
                for (int c = x; c < integerArray.Length; c++)
                {
                    if (integerArray.Contains(integerArray[x] + integerArray[c]) && x != c)
                    {
                        Console.WriteLine($"{integerArray[x]} + {integerArray[c]} == {integerArray[x] + integerArray[c]}");

                        contains = false;
                    }
                }
            }

            if (contains)
            {
                Console.WriteLine("No");
            }
        }
    }
}