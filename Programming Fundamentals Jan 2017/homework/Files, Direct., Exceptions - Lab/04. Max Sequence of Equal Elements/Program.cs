
namespace _01.Max_Sequence_of_Equal_Elements
{
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class MaxSequence
    {
        public static void Main(string[] args)
        {
            int[] numbers = File.ReadAllText("input.txt").Split().Select(int.Parse).ToArray();

            List<int> start = new List<int>();
            List<int> count = new List<int>();
            int bestCount = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    bestCount++;

                    if (i == numbers.Length - 2)
                    {
                        start.Add(numbers[i]);
                        count.Add(bestCount);
                    }
                }
                else
                {
                    start.Add(numbers[i]);
                    count.Add(bestCount);
                    bestCount = 1;
                }
            }

            int bestCountIndex = count.IndexOf(count.Max());

            List<string> output = new List<string>();
            for (int i = 0; i < count.Max(); i++)
            {
                output.Add($"{start[bestCountIndex]} ");
            }

            File.WriteAllText("output.txt", string.Join(" ", output));
        }
    }
}