namespace _09.Extract_Middle_1__2_or_3_Elements
{
    using System;

    public class ExtractMiddleElements
    {
        public static void Main(string[] args)
        {
            string arrayInput = Console.ReadLine();
            string[] helpingArray = arrayInput.Split(' ');

            int n = helpingArray.Length;

            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = Convert.ToInt32(helpingArray[i]);
            }

            if (n == 1)
            {
                Console.WriteLine(SingleElement(nums));
            }
            else if (n % 2 == 0)
            {
                Console.WriteLine(EvenElement(nums, n));
            }
            else
            {
                Console.WriteLine(OddElement(nums, n));
            }
        }

        public static string SingleElement(int[] nums)
        {
            return $"{{ {nums[0]} }}";
        }

        public static string EvenElement(int[] nums, int n)
        {
            return $"{{ {nums[n / 2 - 1]}, {nums[n / 2]} }}";
        }

        public static string OddElement(int[] nums, int n)
        {
            return $"{{{nums[n / 2 - 1]}, {nums[n / 2]}, {nums[n / 2 + 1]}}}";
        }
    }
}