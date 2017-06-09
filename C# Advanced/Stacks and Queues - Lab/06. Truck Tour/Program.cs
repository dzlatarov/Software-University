namespace _06.Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TruckTour
    {
        static void Main(string[] args)
        {
            int pumpsCount = int.Parse(Console.ReadLine());

            var pumps = new Queue<int[]>();

            for (int i = 0; i < pumpsCount; i++)
            {
                pumps.Enqueue(Console.ReadLine().Split(' ')
                    .Select(int.Parse)
                    .ToArray());
            }

            for (int currentPumpIndex = 0; currentPumpIndex < pumpsCount; currentPumpIndex++)
            {
                if (isAnswer(pumpsCount, pumps))
                {
                    Console.WriteLine(currentPumpIndex);
                    break;
                }
                else
                {
                    int[] currentPump = pumps.Dequeue();
                    pumps.Enqueue(currentPump);
                }
            }
        }

        public static bool isAnswer(int pumpsCount, Queue<int[]> pumps)
        {
            int fuelCount = 0;
            bool isAnwer = true;

            for (int i = 0; i < pumpsCount; i++)
            {
                int[] currentPump = pumps.Dequeue();
                fuelCount += currentPump[0] - currentPump[1];

                if (fuelCount < 0)
                {
                    isAnwer = false;
                }

                pumps.Enqueue(currentPump);
            }

            return isAnwer;
        }
    }
}