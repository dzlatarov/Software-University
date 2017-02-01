namespace _02.Longest_Increasing_Subsequence__LIS_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LIS
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> numbersSorted = new List<int>();
            numbersSorted.AddRange(numbers);
            numbersSorted.Sort();

            List<int> subsequence = new List<int>();
            int counter = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (counter == numbers.Count)
                {
                    break;
                }
                else if (subsequence.ElementAtOrDefault(i) == 0)
                {
                    subsequence.Add(numbers[counter]);
                    i--;
                    counter++;
                }
                else if (subsequence[i] > numbers[counter])
                {         
                    subsequence[i] = numbers[counter];
                    i--;
                    counter++;
                }
                else if (subsequence[i] < numbers[counter])
                {
                    subsequence.Add(numbers[counter]);
                    counter++;
                }             
            }

            foreach(int integer in subsequence)
            {
                Console.Write($"{integer} ");
            }
        }
    }
}