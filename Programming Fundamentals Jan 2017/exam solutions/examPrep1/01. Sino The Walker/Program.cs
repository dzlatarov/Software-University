namespace _01.Sino_The_Walker
{
    using System;
    using System.Globalization;
    using System.Numerics;

    public class SinoTheWalker
    {
        public static void Main(string[] args)
        {
            DateTime simoLeaves = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            BigInteger numberOfSteps = BigInteger.Parse(Console.ReadLine());
            BigInteger timeForEachStep = BigInteger.Parse(Console.ReadLine());

            BigInteger secondsElapsedTotal = numberOfSteps * timeForEachStep;
            double secondsElapsed = (double) (secondsElapsedTotal % 86400;
            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", simoLeaves.AddSeconds(secondsElapsed));
        }
    }
}