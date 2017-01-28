namespace _08.Most_Frequent_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MostFrequentNumber
    {
        public static void Main(string[] args)
        {
            ushort[] numbers = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();

            List<ushort> differntNumbers = new List<ushort>();
            List<ushort> differentNumbersCount = new List<ushort>();
            foreach (ushort number in numbers)
            {
                if (!differntNumbers.Contains(number))
                {
                    differntNumbers.Add(number);
                }
            }

            for (ushort i = 0; i < differntNumbers.Count; i++)
            {
                ushort count = 0;
                for (ushort x = 0; x < numbers.Count(); x++)
                {
                    if (differntNumbers[i] == numbers[x])
                    {
                        count++;
                    }
                }

                differentNumbersCount.Add(count);
            }

            for (ushort i = 0; i < differntNumbers.Count; i++)
            {
                if (differentNumbersCount[i] == differentNumbersCount.Max())
                {
                    Console.WriteLine(differntNumbers[i]);
                    break;
                }
            }
        }
    }
}