namespace _01.Odd_Lines
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt");

            List<string> output = new List<string>();

            for (int i = 0; i < input.Count(); i++)
            {
                if (i % 2 != 0)
                {
                    output.Add(input[i]);
                }
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}