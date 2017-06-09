namespace _05.RoundingAwayFromZero
{
    using System;

    public class RoundAwayFromZero
    {
        public static void Main(string[] args)
        {
            string inputArray = Console.ReadLine();
            string[] array = inputArray.Split(' ');
            double[] doubleArray = new double[array.Length];

            for (int i = 0; i <= array.Length - 1; i++)
            {
                doubleArray[i] = Convert.ToDouble(array[i]);

                Console.WriteLine($"{doubleArray[i]} => {Math.Round(doubleArray[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
