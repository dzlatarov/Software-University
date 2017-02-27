namespace _1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double distanceTraveled = double.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            double distanceMoved = (wingFlaps / 1000m) * distanceTraveled;
            long secondsElapsedFlapping = (wingFlaps / 100);
            long secondsElapsedResting = (wingFlaps / endurance) * 5;
            long totalSecondsElapsed = secondsElapsedFlapping + secondsElapsedResting;

            Console.WriteLine($"{distanceMoved:F2} m.");
            Console.WriteLine($"{totalSecondsElapsed} s.");
        }
    }
}