using System;

using System.Text.RegularExpressions;

public static class ValidUsernames
{
    public static void Main(string[] args)
    {
        var matcher = new Regex(@"^[a-zA-Z|\d|\-|_]{3,16}$");

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "END")
            {
                break;
            }

            var isMatch = matcher.IsMatch(input);

            if (isMatch)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}