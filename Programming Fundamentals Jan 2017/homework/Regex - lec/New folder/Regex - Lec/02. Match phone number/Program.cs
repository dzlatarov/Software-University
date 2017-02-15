namespace _02.Match_phone_number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class MatchPhoneNumber
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"\+\d{3}\s\d\s\d{3}\s\d{4}");

            var matches = regex.Matches(input);

            foreach(Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
