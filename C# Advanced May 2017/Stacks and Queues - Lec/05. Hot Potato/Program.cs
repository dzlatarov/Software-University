namespace _5.Hot_Potato
{
    using System;
    using System.Collections.Generic;

    class HotPotato
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(input.Split(' '));

            while(queue.Count > 1)
            {
                for(int i = 0; i < number - 1; i++)
                {
                    string reminder = queue.Dequeue();
                    queue.Enqueue(reminder);
                }

                Console.WriteLine("Removed {0}", queue.Dequeue());
            }

            Console.WriteLine("Last is {0}", queue.Dequeue());
        }
    }
}