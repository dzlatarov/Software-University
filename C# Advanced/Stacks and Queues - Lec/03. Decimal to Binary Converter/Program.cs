namespace _03.Decimal_to_Binary_Converter
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            do
            {
                stack.Push(input % 2);

                input = input / 2;
            } while (input != 0);

            while(stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}