namespace _01.Reverse_Numbers_with_a_Stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ReverseNumbersWithStack
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var stack = new Stack<int>(input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            while(stack.Count() > 0)
            {
                Console.Write("{0} ", stack.Pop());
            }
        }
    }
}