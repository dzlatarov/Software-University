namespace _05.Calculate_Sequence_with_Queue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CalculateSequenceWithQueue
    {
        static void Main(string[] args)
        {
            var queueA = new Queue<long>();
            var queueB = new Queue<long>();

            queueA.Enqueue(long.Parse(Console.ReadLine()));
            queueB.Enqueue(queueA.Peek());

            int n = 1;
            for(int i = 0; i < 49; i++)
            {
                switch(n)
                {
                    case 1:
                        queueA.Enqueue(queueB.Peek() + 1);
                        queueB.Enqueue(queueB.Peek() + 1);
                        n++;
                        break;
                    case 2:
                        queueA.Enqueue(queueB.Peek() * 2 + 1);
                        queueB.Enqueue(queueB.Peek() * 2 + 1);
                        n++;
                        break;
                    case 3:
                        queueA.Enqueue(queueB.Peek() + 2);
                        queueB.Enqueue(queueB.Peek() + 2);
                        n = 1;

                        queueB.Dequeue();
                        break;
                }
            }

            while(queueA.Count() > 0)
            {
                Console.Write("{0} ", queueA.Dequeue());
            }
        }
    }
}
