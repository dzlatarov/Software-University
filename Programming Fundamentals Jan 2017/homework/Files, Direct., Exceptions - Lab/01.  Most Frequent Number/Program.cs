
namespace _08.Most_Frequent_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class MostFrequentNumber
    {
        public static void Main(string[] args)
        {
            ushort[] numbers = File.ReadAllText("input.txt").Split(' ').Select(ushort.Parse).ToArray();

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

            int output = 0;
            for (ushort i = 0; i < differntNumbers.Count; i++)
            {
                if (differentNumbersCount[i] == differentNumbersCount.Max())
                {
                    output = differntNumbers[i];
                    break;
                }
            }

            File.WriteAllText("output.txt", Convert.ToString(output));
        }
    }
}