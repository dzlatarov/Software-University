using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var stack = new Stack<string>(input.Split(' '));

            int result = 0;
            while(stack.Count() > 1)
            {
                int a = int.Parse(stack.Pop());
                string sign = stack.Pop();

                if(sign == "+" || sign == string.Empty)
                {
                    result += a;
                }
                else
                {
                    result -= a;
                }
            }

            Console.WriteLine(result + int.Parse(stack.Pop()));               
        }
    }
}
