namespace _04.Character_Multiplier
{
    using System;
    using System.Linq;

    public class CharacterMultiplier
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string str1 = input[0];
            string str2 = input[1];

            int result = 0;
            string shoterString = ShorterString(str1, str2);
            string longerString = LongerString(str1, str2);

            for (int i = 0; i < longerString.Length; i++)
            {
                if (i + 1 <= shoterString.Length)
                {
                    result += Convert.ToInt32(shoterString[i]) * Convert.ToInt32(longerString[i]);
                }
                else
                {
                    result += Convert.ToInt32(longerString[i]);
                }
            }

            Console.WriteLine(result);
        }

        public static string LongerString(string str1, string str2)
        {
            if (str1.Length >= str2.Length)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }

        public static string ShorterString(string str1, string str2)
        {
            if (str1.Length >= str2.Length)
            {
                return str2;
            }
            else
            {
                return str1;
            }
        }
    }
}