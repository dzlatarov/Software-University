namespace _06.ReverseAnArrayOfStrings
{
    using System;

    public class ReverseArrayStrings
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] stringArray = input.Split(' ');

            for(int i = stringArray.Length - 1; i >= 0; i--)
            {
                Console.Write($"{stringArray[i]} ");
            }
        }
    }
}