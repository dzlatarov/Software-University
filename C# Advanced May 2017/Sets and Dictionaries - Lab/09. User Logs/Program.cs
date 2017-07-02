using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class UserLogs
{
    public static void Main(string[] args)
    {
        var logs = new Dictionary<string, List<string>>();
        Regex matcher = new Regex(@"IP=(.+) message=.+ user=(.+)");

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }
            else
            {
                var filteredInput = matcher.Match(input);

                string name = filteredInput.Groups[2].ToString();
                string IP = filteredInput.Groups[1].ToString();

                if (logs.ContainsKey(name))
                {
                    logs[name].Add(IP);
                }
                else
                {
                    var initialList = new List<string>();
                    initialList.Add(IP);

                    logs[name] = initialList;
                }
            }
        }

        int counter = 1;
        foreach (var kvp in logs.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{kvp.Key}: ");
            foreach (string str in kvp.Value.Distinct())
            {
                if (kvp.Value.Distinct().Count() != counter)
                {
                    Console.Write("{0} => {1}, ", str, kvp.Value.Count(x => x == str));
                }
                else
                {
                    Console.Write("{0} => {1}.", str, kvp.Value.Count(x => x == str));
                }

                counter++;
            }
            Console.WriteLine();

            counter = 1;
        }
    }
}