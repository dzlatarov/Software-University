namespace _01.Charity_Marathon
{
    using System;

    public class CharityMarathon
    {
        public static void Main()
        {
            long dayCount = long.Parse(Console.ReadLine());
            long runnerCount = long.Parse(Console.ReadLine());
            long lapsCount = long.Parse(Console.ReadLine());
            long lapLength = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            if (runnerCount > trackCapacity * dayCount)
            {
                runnerCount = trackCapacity * dayCount;
            }

            decimal totalLengthRan = runnerCount * lapsCount * lapLength;
            decimal totalLengthRanInKilometers = totalLengthRan / 1000m;
            decimal result = totalLengthRanInKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {Math.Round(result, 2):f2}");
        }
    }
}