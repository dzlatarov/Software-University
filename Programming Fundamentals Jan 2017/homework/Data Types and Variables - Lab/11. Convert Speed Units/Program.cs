using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceMeters = float.Parse(Console.ReadLine());
            float hours= float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float meteresPerSecond = distanceMeters / (hours * 3600f + minutes * 60f + seconds);
            float kilometersPerHour = (distanceMeters / 1000f) / (hours + minutes / 60f + seconds / 3600f);
            float milesPerHour = (distanceMeters / 1609f) / (hours + minutes / 60f + seconds / 3600f);
       

            Console.WriteLine("{0:0.########}", meteresPerSecond);
            Console.WriteLine("{0:0.########}", kilometersPerHour);
            Console.WriteLine("{0:0.########}", milesPerHour);
        }
    }
}
