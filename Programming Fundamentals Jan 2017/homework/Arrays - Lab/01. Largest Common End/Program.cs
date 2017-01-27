namespace _01.Largest_Common_End
{
    using System;

    public class LargestCommonEnd
    {
        public static void Main(string[] args)
        {
            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();

            string[] arrayOne = inputOne.Split(' ');
            string[] arrayTwo = inputTwo.Split(' ');

            int shorterArrayLength = arrayOne.Length >= arrayTwo.Length ? arrayTwo.Length : arrayOne.Length;
            int biggerArrayLength = arrayOne.Length >= arrayTwo.Length ? arrayOne.Length : arrayTwo.Length;

            int leftToRightCount = 0;
            for (int i = 0; i < shorterArrayLength; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    leftToRightCount++;
                }
                else
                {
                    break;
                }
            }

            int rightToLeftCount = 0;
            for (int i = shorterArrayLength - 1; i >= 0; i--)
            {
                if (arrayOne.Length >= arrayTwo.Length)
                {
                    if (arrayOne[biggerArrayLength - 1] == arrayTwo[shorterArrayLength - 1])
                    {
                        rightToLeftCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (arrayTwo[biggerArrayLength - 1] == arrayOne[shorterArrayLength - 1])
                    {
                        rightToLeftCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                biggerArrayLength--;
                shorterArrayLength--;
            }

            Console.WriteLine(leftToRightCount >= rightToLeftCount ? leftToRightCount : rightToLeftCount);
        }
    }
}