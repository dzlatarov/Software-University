namespace _01.Randomize_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RandomizeWords
    {
        public static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<string> output = new List<string>();

            Random rng = new Random();

            while(input.Count != 0)
            {
                int random = rng.Next(0, input.Count);

                output.Add(input[random]);
                input.RemoveAt(random);
            }

            foreach(string str in output)
            {
                Console.WriteLine(str);
            }
        }
    }
}