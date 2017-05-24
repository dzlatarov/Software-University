namespace _04.Matching_Brackets
{
    using System;
    using System.Collections.Generic;

    class MatchingBrackets
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<int>();

            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(')
                {
                    stack.Push(i);
                }
                else if(input[i] == ')')
                {
                    for(int k = stack.Pop(); k <= i; k++)
                    {
                        Console.Write(input[k]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}