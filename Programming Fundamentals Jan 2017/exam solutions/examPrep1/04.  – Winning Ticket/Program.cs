namespace _04.__Winning_Ticket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class WinningTicket
    {
        public static void Main(string[] args)
        {
            List<string> tickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Regex ticketMatch = new Regex(@"[\@|\#|\$|\^]");
            foreach (string ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else if (!ticketMatch.IsMatch(ticket))
                {
                    Console.WriteLine($@"ticket ""{ticket}"" - no match");
                }
                else
                {
                    StringBuilder firstHalfBuilder = new StringBuilder();
                    StringBuilder secondHalfBuilder = new StringBuilder();
                    for (int i = 0; i < 10; i++)
                    {
                        firstHalfBuilder.Append(ticket[i]);
                        secondHalfBuilder.Append(ticket[i + 10]);
                    }

                    string firstHalf = firstHalfBuilder.ToString();
                    string secondHalf = secondHalfBuilder.ToString();

                    if (firstHalf == new string(firstHalf[0], 10) && firstHalf == secondHalf)
                    {
                        Console.WriteLine($@"ticket ""{ticket}"" - 10{firstHalf[0]} Jackpot!");
                    }
                    else
                    {
                        Regex matcher = new Regex(@"[\@|\#|\$|\^]+");
                        var firstHalfMatch = matcher.Matches(firstHalf);
                        var secondHalfMatch = matcher.Matches(secondHalf);
                        Dictionary<char, int> firstHalfMatches = new Dictionary<char, int>();
                        Dictionary<char, int> secondHalfMatches = new Dictionary<char, int>();

                        foreach (Match match in firstHalfMatch)
                        {
                            firstHalfMatches[match.ToString()[0]] = match.Length;
                        }

                        foreach (Match match in secondHalfMatch)
                        {
                            secondHalfMatches[match.ToString()[0]] = match.Length;
                        }

                        Dictionary<char, int> bestMatches = new Dictionary<char, int>();
                        foreach (var kvp in firstHalfMatches)
                        {
                            if (secondHalfMatches.ContainsKey(kvp.Key))
                            {
                                bestMatches[kvp.Key] = kvp.Value < secondHalfMatches[kvp.Key] ? kvp.Value : secondHalfMatches[kvp.Key];
                            }
                            else
                            {
                                bestMatches[kvp.Key] = 0;
                            }
                        }

                        if (bestMatches.Max().Value >= 6 && bestMatches.Max().Value != 0)
                        {
                            Console.WriteLine($@"ticket ""{ticket}"" - {bestMatches.Max().Value}{MaxKey(bestMatches)}");
                        }
                        else
                        {
                            Console.WriteLine($@"ticket ""{ticket}"" - no match");
                        }
                    }
                }
            }
        }

        public static char MaxKey(Dictionary<char, int> bestMatches)
        {
            char ayy = ' ';
            foreach (var kvp in bestMatches)
            {
                if (bestMatches[kvp.Key] == bestMatches.Max().Value)
                {
                    ayy = kvp.Key;
                }
            }
            return ayy;
        }
    }
}