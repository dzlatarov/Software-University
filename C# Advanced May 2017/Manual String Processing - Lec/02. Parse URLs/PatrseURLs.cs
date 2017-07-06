using System;
using System.Text.RegularExpressions;

public class PatrseURLs
{
    public static void Main(string[] args)
    {
        string url = Console.ReadLine();

        var matcher = new Regex(@"(.+):\/\/(.+?)\/($|.+)");

        if(matcher.IsMatch(url))
        {
            var matches = matcher.Match(url);

            string protocol = matches.Groups[1].ToString();
            string server = matches.Groups[2].ToString();
            string resources = matches.Groups[3].ToString();

            if(resources.Contains(@"://"))
            {
                Console.WriteLine("Invalid URL");
            }
            else
            {
                Console.WriteLine($"Protocol = {protocol}");
                Console.WriteLine($"Server = {server}");
                Console.WriteLine($"Resources = {resources}");
            }
        }
        else
        {
            Console.WriteLine("Invalid URL");
        }
    }
}