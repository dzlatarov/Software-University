namespace _03.Maximum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MaximumElements
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            var maxStack = new Stack<int>();
            for(int i = 0; i < numberOfCommands; i++)
            {
                int[] command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();



                switch (command[0])
                {
                    case 1:
                        stack.Push(command[1]);

                        if (maxStack.Count == 0 || maxStack.Max() < command[1])
                        {
                            maxStack.Push(command[1]);
                        }
                        break;

                    case 2:
                        if(stack.Pop() == maxStack.Max())
                        {
                            maxStack.Pop();
                        }

                        break;

                    case 3:
                   
                        Console.WriteLine(maxStack.Peek());

                        break;
                }
            }
        }
    }
}