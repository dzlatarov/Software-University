namespace _01.Reverse_string
{
    using System;
    using System.Linq;

    public class ReverseString
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result= new string(input.Reverse().ToArray());

            Console.WriteLine(result);
        }
    }
}