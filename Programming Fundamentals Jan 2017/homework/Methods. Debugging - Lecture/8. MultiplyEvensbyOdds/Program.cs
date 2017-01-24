namespace _8.MultiplyEvensbyOdds
{
    using System;

    public class EvensTimesOdds
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);

            Console.WriteLine(result);
        }

        public static int GetSumOfOddDigits(int number)
        {
            int sum = 0;

            while (Math.Abs(number) > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum = sum + lastDigit;
                }

                number /= 10;
            }

            return sum;
        }

        public static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;

            while (Math.Abs(number) > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum = sum + lastDigit;
                }

                number /= 10;
            }

            return sum;
        }
    }
}
