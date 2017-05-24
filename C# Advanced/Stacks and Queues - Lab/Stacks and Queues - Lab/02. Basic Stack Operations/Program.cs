namespace _02.Basic_Stack_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] elementsToPush = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int avaibleElements = elementsToPush.Count();
            var stack = new Stack<int>();
            int index = 0;

            while(input[0] > 0 || avaibleElements > 0)
            {
                stack.Push(elementsToPush[index]);

                avaibleElements--;
                input[0]--;
                index++;
            }

            while(input[1] > 0)
            {
                stack.Pop();

                input[1]--;
            }

            if(stack.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count() == 0)
            {
                Console.WriteLine('0');
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}