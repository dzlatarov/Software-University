namespace _02.Line_Numbers
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
   
    public class LineNumbers
    {
        public static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt");

            List<string> output = new List<string>();
            for (int i = 0; i < input.Count(); i++)
            {
                output.Add($"{i + 1}. {input[i]}");
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}
