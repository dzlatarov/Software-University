namespace _12.MasterNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MasterNumbers
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i))
                {
                    if (ContainsEvenDigit(i))
                    {
                        if (SumDivisibleBySeven(i))
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }

        public static bool IsPalindrome(int i)
        {
            int n = i;
            int t = n;
            int a, s = 0;

            while (n > 0)
            {
                a = n % 10;
                s = (s * 10) + a;
                n = n / 10;
            }

            if (t == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ContainsEvenDigit(int i)
        {
            bool containsEvenDigit = false;

            for (int n = i; n != 0; n = n / 10)
            {
                if ((n % 10) % 2 == 0)
                {
                    containsEvenDigit = true;
                    break;
                }
            }

            return containsEvenDigit;
        }

        public static bool SumDivisibleBySeven(int i)
        {
            bool sumDivisibleBySeven = false;

            int sum = 0;
            for (int n = i; n != 0; n = n / 10)
            {
                sum += n % 10;
            }

            if (sum % 7 == 0)
            {
                sumDivisibleBySeven = true;
            }

            return sumDivisibleBySeven;
        }
    }
}