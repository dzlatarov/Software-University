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
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<string> longestSubsequence = new List<string>();
            List<int> subsequenceCount = new List<int>();
            string subsequence = string.Empty;
            int counter = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int x = i; x < numbers.Length; x++)
                {
                    if (numbers[i] < numbers[x])
                    {
                        counter++;
                        subsequence += $"{numbers[x]} ";
                        subsequenceCount.Add(counter);
                        longestSubsequence.Add(subsequence);
                        if (x == numbers.Length - 2)
                        {
                            subsequenceCount.Add(counter);
                            longestSubsequence.Add(subsequence);
                        }
                    }
                    else
                    {
                        subsequenceCount.Add(counter);
                        longestSubsequence.Add(subsequence);
                        subsequence = string.Empty;
                    }
                }
            }
            for(int i = 0; i <= longestSubsequence.Count; i++)
            {
                Console.WriteLine(longestSubsequence[i]);
            }

        }
    }
}
