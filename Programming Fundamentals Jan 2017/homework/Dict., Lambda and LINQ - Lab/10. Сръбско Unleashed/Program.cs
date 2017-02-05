namespace _10.Сръбско_Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShittyMusicUnleashed
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> ticketsSold = new Dictionary<string, Dictionary<string, long>>();

            char[] ignore = new char[] { '@' };
            char[] ignoreTwo = new char[] { ' ' };
            while (true)
            {
            here:
                List<string> input = Console.ReadLine().Split(ignore).ToList();
                if (input.Count == 1 || input[0] == "End")
                {
                    break;
                }
                else
                {
                    try
                    {
                        string singer = input[0];
                        input.RemoveAt(0);

                        string helper = input[0];
                        input = helper.Split(ignoreTwo, StringSplitOptions.RemoveEmptyEntries).ToList();

                        long revenue = Convert.ToInt64(input[input.Count - 2]) * Convert.ToInt64(input[input.Count - 1]);
                        input.RemoveAt(input.Count - 1);
                        input.RemoveAt(input.Count - 1);

                        string place = string.Join(" ", input);

                        Dictionary<string, long> singerRevenue = new Dictionary<string, long>();

                        if (!ticketsSold.ContainsKey(place))
                        {
                            singerRevenue[singer] = revenue;

                            ticketsSold[place] = singerRevenue;
                        }
                        else
                        {
                            singerRevenue = ticketsSold[place];

                            if (singerRevenue.ContainsKey(singer))
                            {
                                singerRevenue[singer] += revenue;
                            }
                            else
                            {
                                singerRevenue.Add(singer, revenue);
                            }

                            ticketsSold[place] = singerRevenue;
                        }
                    }
                    catch (Exception)
                    {
                        goto here;
                    }
                }
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> kvp in ticketsSold)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (KeyValuePair<string, long> kvpTwo in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {kvpTwo.Key}-> {kvpTwo.Value}");
                }
            }
        }
    }
}