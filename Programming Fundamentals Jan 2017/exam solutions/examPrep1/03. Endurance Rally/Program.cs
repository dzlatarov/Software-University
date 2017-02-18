namespace _03.Endurance_Rally
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EnduranceRally
    {
        public static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double[] track = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            int[] checkPointsIndex = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Dictionary<string, double> driversFuel = new Dictionary<string, double>();
            foreach (string driver in drivers)
            {
                driversFuel[driver] = Convert.ToInt32(driver[0]);
            }

            foreach (var kvp in driversFuel.ToList())
            {
                for (int i = 0; i < track.Count(); i++)
                {
                    if (checkPointsIndex.Contains(i))
                    {
                        driversFuel[kvp.Key] += track[i];
                    }
                    else
                    {
                        driversFuel[kvp.Key] -= track[i];
                    }
           
                    if (driversFuel[kvp.Key] <= 0)
                    {
                        Console.WriteLine($"{kvp.Key} - reached {i}");
                        break;
                    }
                    else if (driversFuel[kvp.Key] > 0 && i == track.Count() - 1)
                    {
                        Console.WriteLine($"{kvp.Key} - fuel left {driversFuel[kvp.Key]:f2}");
                    }
                }
            }
        }
    }
}