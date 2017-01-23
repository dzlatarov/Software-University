namespace _2.Sign_of_Integer_Number
{
    using System;

    public class SignOfIntegerNumber
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }

        public static void PrintSign(int number)
        {           
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
