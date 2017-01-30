namespace _02.Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main(string[] args)
        {
            List<string> lists = Console.ReadLine().Split('|').ToList();

            lists.Reverse();
            Console.WriteLine(string.Join(" ", lists));
        }
    }
}