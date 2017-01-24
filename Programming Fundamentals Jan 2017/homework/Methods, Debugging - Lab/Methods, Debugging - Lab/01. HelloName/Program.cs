namespace _01.HelloName
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            HelloName(name);
        }

        public static void HelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
