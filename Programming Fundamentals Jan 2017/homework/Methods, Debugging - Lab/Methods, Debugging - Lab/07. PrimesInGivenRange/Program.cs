namespace _07.PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class PrimesInGivenRange
    {
        public static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            string result = string.Join(", ", FindPrimesInRange(startNum, endNum));
            Console.WriteLine(result);
        }

        public static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primeNumbers = new List<int>();

            for (; startNum <= endNum; startNum++)
            {
                for (int i = 3; i <= startNum; i++)
                {
                    if (i > startNum)
                    {
                        break;
                    }
                    else if (startNum == 0 || startNum == 1)
                    {
                        break;
                    }
                    else if (startNum % i == 0 && startNum != i)
                    {
                        break;
                    }
                    else if (startNum == i)
                    {
                        primeNumbers.Add(startNum);
                    }
                }
            }

            return primeNumbers;
        }
    }
}