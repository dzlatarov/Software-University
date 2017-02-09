namespace _09.Index_of_Letters
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    public class IndexOfLetters
    {
        public static void Main(string[] args)
        {
            string letters = File.ReadAllText("input.txt");

            List<string> output = new List<string>();
            foreach (char letter in letters)
            {
                output.Add($"{letter} -> {Convert.ToInt32(letter) - 97}");
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}