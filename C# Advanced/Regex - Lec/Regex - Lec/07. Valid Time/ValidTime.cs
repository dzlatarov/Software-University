using System;
using System.Text.RegularExpressions;

public static class ValidTime
{
    public static void Main(string[] args)
    {
        var matcher = new Regex(@"^(([0][0-9]:[0-5][0-9]:[0-5][0-9])|([1][1]:[0-5][0-9]:[0-5][0-9])|([0][0]:[0-5][0-9]:[0-5][0-9])) (AM|PM)$");

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