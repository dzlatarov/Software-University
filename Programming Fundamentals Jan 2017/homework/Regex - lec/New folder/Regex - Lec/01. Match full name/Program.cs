namespace _01.Match_full_name
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var regex = new Regex("\\b[A-Z][a-z]+\\s[A-Z][a-z]+\\b");

            var matches = regex.Matches(input);

            foreach(Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
