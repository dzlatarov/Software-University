namespace _11.Equal_Sums
{
    using System.Linq;
    using System.IO;

    public class EqualSums
    {
        public static void Main(string[] args)
        {
            int[] numbers = File.ReadAllText("input.txt").Split().Select(int.Parse).ToArray();

            if (SumIsZero(numbers))
            {
                File.WriteAllText("output.txt", "0");
            }
            else
            {
                bool sumDoesNotExist = true;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (LeftSum(i, numbers) == RightSum(i, numbers))
                    {
                        File.WriteAllText("output.txt", $"{i}");
                        sumDoesNotExist = false;
                        break;
                    }
                }

                if (sumDoesNotExist)
                {
                    File.WriteAllText("output.txt", "no");
                }
            }
        }

        public static bool SumIsZero(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int LeftSum(int i, int[] numbers)
        {
            int sum = 0;
            for (int x = 0; x < i; x++)
            {
                sum += numbers[x];
            }

            return sum;
        }

        public static int RightSum(int i, int[] numbers)
        {
            int sum = 0;
            for (int x = i + 1; x < numbers.Length; x++)
            {
                sum += numbers[x];
            }

            return sum;
        }
    }
}