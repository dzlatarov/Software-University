namespace MathPotato
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MathPotato
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(input.Split(' '));

            int cycle = 1;

            while (queue.Count > 1)
            {
                for (int i = 0; i < number - 1; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                if (PrimeTool.IsPrime(cycle))
                {
                    Console.WriteLine("Prime {0}", queue.Peek());
                }
                else
                {
                    Console.WriteLine("Removed {0}", queue.Dequeue());
                }
                cycle++;
            }

            Console.WriteLine("Last is {0}", queue.Dequeue());
        }
    }
}




public static class PrimeTool
{
    public static bool IsPrime(int candidate)
    {
        // Test whether the parameter is a prime number.
        if ((candidate & 1) == 0)
        {
            if (candidate == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Note:
        // ... This version was changed to test the square.
        // ... Original version tested against the square root.
        // ... Also we exclude 1 at the end.
        for (int i = 3; (i * i) <= candidate; i += 2)
        {
            if ((candidate % i) == 0)
            {
                return false;
            }
        }
        return candidate != 1;
    }
}
