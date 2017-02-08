namespace _04.Merge_Files
{
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input1 = File.ReadAllLines("input1.txt");
            string[] input2 = File.ReadAllLines("input2.txt");
            List<string> output = new List<string>();

            for (int i = 0; i < input1.Length; i++)
            {
                output.Add(input1[i]);
                output.Add(input2[i]);
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}