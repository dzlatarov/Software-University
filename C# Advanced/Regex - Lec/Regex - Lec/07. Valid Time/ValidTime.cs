using System;
using System.Text.RegularExpressions;

public static class ValidTime
{
    public static void Main(string[] args)
    {
        var matcher = new Regex(@"^([1-9]|1[0-2]|0[1-9]){1}(:[0-5][0-9]:[0-5][0-9] [AP][M]){1}$");

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