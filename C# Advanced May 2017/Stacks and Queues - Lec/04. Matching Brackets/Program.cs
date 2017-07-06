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
            stack.Push(input);

            Console.WriteLine(stack.Any());
        }
    }
}