using System;
using System.Text.RegularExpressions;

public static class MatchPhoneNumber
{
    public static void Main()
    {
        var matcher = new Regex(@"(^| )(\+359 \d \d{3} \d{4})|(\+359-\d-\d{3}-\d{4})$");

        string input = string.Empty;

        while (input != "end")
        {
            input = Console.ReadLine();

            if (matcher.IsMatch(input))
            {
                Console.WriteLine(input);
            }
        }
    }
}