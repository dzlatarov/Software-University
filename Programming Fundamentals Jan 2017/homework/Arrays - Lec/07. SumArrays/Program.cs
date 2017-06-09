namespace _07.SumArrays
{
    using System;

    public class SumArrays
    {
        public static void Main(string[] args)
        {
            string arrayOneInput = Console.ReadLine();
            string arrayTwoInput = Console.ReadLine();
            string[] arrayOne = arrayOneInput.Split(' ');
            string[] arrayTwo = arrayTwoInput.Split(' ');

            int[] arrayOneInt = new int[arrayOne.Length];
            int[] arrayTwoInt = new int[arrayTwo.Length];
            int[] arraySum = new int[arrayOneInt.Length >= arrayTwoInt.Length ? arrayOneInt.Length : arrayTwoInt.Length];

            for (int i = 0; i < arrayOne.Length; i++)
            {
                arrayOneInt[i] = Convert.ToInt32(arrayOne[i]);
            }

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                arrayTwoInt[i] = Convert.ToInt32(arrayTwo[i]);
            }

            for (int i = 0; i < arraySum.Length; i++)
            {
                arraySum[i] = arrayOneInt[i % arrayOneInt.Length] + arrayTwoInt[i % arrayTwoInt.Length];
                Console.Write($"{arraySum[i]} ");
            }
        }
    }
}
