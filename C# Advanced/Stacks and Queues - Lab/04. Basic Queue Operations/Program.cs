namespace _04.Basic_Queue_Operations
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
            var queue = new Queue<int>();
            int index = 0;

            while (input[0] > 0 || avaibleElements > 0)
            {
                queue.Enqueue(elementsToPush[index]);

                avaibleElements--;
                input[0]--;
                index++;
            }

            while (input[1] > 0)
            {
                queue.Dequeue();

                input[1]--;
            }

            if (queue.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count() == 0)
            {
                Console.WriteLine('0');
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}