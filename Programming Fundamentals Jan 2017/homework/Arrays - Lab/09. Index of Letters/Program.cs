namespace _09.Index_of_Letters
{
    using System;

    public class IndexOfLetters
    {
        public static void Main(string[] args)
        {
            string letters = Console.ReadLine();

            foreach (char letter in letters)
            {
                Console.WriteLine($"{letter} -> {Convert.ToInt32(letter) - 97}");
            }
        }
    }
}