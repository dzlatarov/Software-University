namespace _02.Advertisement_Message
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    public class AdvertisementMessage
    {
        public static void Main(string[] args)
        {
            string[] phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] authors = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            string[] cities = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            int n = Convert.ToInt32(File.ReadAllText("input.txt"));

            List<string> output = new List<string>();
            Random rng = new Random();
            for (int i = 0; i < n; i++)
            {
                output.Add($"{phrases[rng.Next(0, phrases.Length)]} {events[rng.Next(0, events.Length)]} {authors[rng.Next(0, authors.Length)]} - {cities[rng.Next(0, cities.Length)]}");
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}