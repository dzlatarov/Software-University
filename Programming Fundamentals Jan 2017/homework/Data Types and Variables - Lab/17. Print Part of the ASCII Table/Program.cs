using System;

namespace _17.Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());

            for(;from <= to; from++)
            {
                Console.Write(Convert.ToChar(from) + " ");
            }
        }
    }
}
