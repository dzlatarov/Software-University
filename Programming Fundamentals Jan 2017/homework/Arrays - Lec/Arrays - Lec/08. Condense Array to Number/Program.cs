namespace _08.Condense_Array_to_Number
{
    using System;
    using System.Collections.Generic;

    public class ArrayToNumber
    {
        public static void Main(string[] args)
        {
            string arrayInput = Console.ReadLine();
            string[] helpingArray = arrayInput.Split(' ');

            List<int> nums = new List<int>();
            for (int i = 0; i < helpingArray.Length; i++)
            {
                nums.Add(Convert.ToInt32(helpingArray[i]));
            }

            List<int> condensed = new List<int>();
            while (nums.Count != 1)
            {
                for (int i = 0; i < nums.Count - 1; i++)
                {
                    condensed.Add(nums[i] + nums[i + 1]);
                }

                nums.Clear();

                for (int i = 0; i < condensed.Count; i++)
                {
                    nums.Add(condensed[i]);
                }

                condensed.Clear();
            }

            Console.WriteLine(nums[0]);
        }
    }
}