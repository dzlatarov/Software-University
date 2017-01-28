namespace _06.Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SequenceOfEqualElements
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> bestSequenceList = new List<int>();
            List<int> numberList = new List<int>();
            int count = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers.Length - i == 1)
                {
                    count++;
                    bestSequenceList.Add(count);
                    numberList.Add(numbers[i]);
                    count = 1;
                }
                else if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if(numbers.Length - i == 2)
                    {
                        bestSequenceList.Add(count);
                        numberList.Add(numbers[i]);
                        count = 1;
                    }
                }
                else
                {
                    bestSequenceList.Add(count);
                    count = 1;
                    numberList.Add(numbers[i]);
                }
            }

            for(int i = 0; i < bestSequenceList.Count; i++)
            {
                if(bestSequenceList[i] == bestSequenceList.Max())
                {
                    for(int x = 0; x < bestSequenceList[i]; x++)
                    {
                        Console.Write($"{numberList[i]} ");
                    }
                    break;
                }
            }
        }
    }
}