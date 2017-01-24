namespace _04.NumbersInReversedOrder
{
    using System;
    using System.Linq;

    public class NumbersReversedOrder
    {
        public static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReversedNumber(number));
        }

        public static string ReversedNumber(decimal number)
        {
            string reversedDecimal = new string(number.ToString().Reverse().ToArray());

            return reversedDecimal;
        }  
    }
}
