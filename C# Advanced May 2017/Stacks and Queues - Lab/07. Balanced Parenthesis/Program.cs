using System;
using System.Collections.Generic;
using System.Linq;


public class BalancedParentheses
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();

        var stack = new Stack<char>();
        bool balanced = true;

        foreach (char c in input)
        {
            switch (c)
            {
                case '(':
                case '{':
                case '[':
                    stack.Push(c);
                    break;

                case '}':
                    if (!stack.Any())
                        balanced = false;

                    else if (stack.Pop() != '{')
                        balanced = false;
                    break;

                case ')':
                    if (!stack.Any())
                        balanced = false;

                    else if (stack.Pop() != '(')
                        balanced = false;
                    break;

                case ']':
                    if (!stack.Any())
                        balanced = false;

                    else if (stack.Pop() != '[')
                        balanced = false;
                    break;
            }
        }

        if (balanced)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}