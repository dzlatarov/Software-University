using System;
using System.Collections.Generic;
using System.Linq;

public class LogsAggregator
{
    public static void Main(string[] args)
    {
        int inputTimes = int.Parse(Console.ReadLine());
        SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();

        char[] ignore = new char[] { ' ' };
        for (int i = 0; i < inputTimes; i++)
        {
            string[] input = Console.ReadLine().Split(ignore, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string IP = input[0];
            string user = input[1];
            int duration = Convert.ToInt32(input[2]);

            SortedDictionary<string, int> IPDuration = new SortedDictionary<string, int>();

            if (!logs.ContainsKey(user))
            {
                IPDuration[IP] = duration;

                logs[user] = IPDuration;
            }
            else
            {
                IPDuration = logs[user];

                if (IPDuration.ContainsKey(IP))
                {
                    IPDuration[IP] += duration;
                }
                else
                {
                    IPDuration.Add(IP, duration);
                }

                logs[user] = IPDuration;
            }
        }

        foreach (var kvp in logs)
        {
            List<int> totalDuration = kvp.Value.Select(x => x.Value).ToList();

            Console.WriteLine($"{kvp.Key}: {totalDuration.Sum()} [{string.Join(", ", kvp.Value.Select(x => x.Key))}]");
        }
    }
}