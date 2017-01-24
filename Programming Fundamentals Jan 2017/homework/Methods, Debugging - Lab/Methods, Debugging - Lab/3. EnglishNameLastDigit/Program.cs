namespace _3.EnglishNameLastDigit
{
    using System;

    public class EnglishNameLastDigit
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            string result = LastDigitInEnglish(number);
            Console.WriteLine(result);
        }

        public static string LastDigitInEnglish(long number)
        {
            string numberEnglish = string.Empty;

            long lastDigit = Math.Abs(number % 10);
            switch (lastDigit)
            {
                case 0:
                    numberEnglish = "zero";
                    break;

                case 1:
                    numberEnglish = "one";
                    break;

                case 2:
                    numberEnglish = "two";
                    break;

                case 3:
                    numberEnglish = "three";
                    break;

                case 4:
                    numberEnglish = "four";
                    break;

                case 5:
                    numberEnglish = "five";
                    break;

                case 6:
                    numberEnglish = "six";
                    break;

                case 7:
                    numberEnglish = "seven";
                    break;

                case 8:
                    numberEnglish = "eight";
                    break;

                case 9:
                    numberEnglish = "nine";
                    break;
            }

            return numberEnglish;
        }
    }
}