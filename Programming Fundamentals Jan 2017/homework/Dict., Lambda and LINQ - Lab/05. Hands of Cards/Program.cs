namespace _05.Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<string>> playerCards = new Dictionary<string, List<string>>();
            Dictionary<string, int> playerPoints = new Dictionary<string, int>();

            char[] ignore = new char[] { ':' };
            while (true)
            {
                List<string> command = Console.ReadLine().Split(ignore).ToList();

                if (command[0] == "JOKER")
                {
                    break;
                }
                else
                {
                    if (playerCards.ContainsKey(command[0]))
                    {
                        playerCards[command[0]].AddRange(command[1].Split(' ', ',').ToList());
                    }
                    else
                    {
                        playerCards[command[0]] = command[1].Split(' ', ',').ToList();
                    }

                    playerCards[command[0]] = playerCards[command[0]].Distinct().ToList();
                }
            }

            foreach (KeyValuePair<string, List<string>> kvp in playerCards)
            {
                int points = 0;

                foreach (string str in kvp.Value)
                {
                    if (str.StartsWith("2"))
                    {
                        points += 2;
                    }
                    else if (str.StartsWith("3"))
                    {
                        points += 3;
                    }
                    else if (str.StartsWith("4"))
                    {
                        points += 4;
                    }
                    else if (str.StartsWith("5"))
                    {
                        points += 5;
                    }
                    else if (str.StartsWith("6"))
                    {
                        points += 6;
                    }
                    else if (str.StartsWith("7"))
                    {
                        points += 7;
                    }
                    else if (str.StartsWith("8"))
                    {
                        points += 8;
                    }
                    else if (str.StartsWith("9"))
                    {
                        points += 9;
                    }
                    else if (str.StartsWith("10"))
                    {
                        points += 10;
                    }
                    else if (str.StartsWith("J"))
                    {
                        points += 11;
                    }
                    else if (str.StartsWith("Q"))
                    {
                        points += 12;
                    }
                    else if (str.StartsWith("K"))
                    {
                        points += 13;
                    }
                    else if (str.StartsWith("A"))
                    {
                        points += 14;
                    }
                    ////
                    if (str.EndsWith("S"))
                    {
                        points *= 4;
                    }
                    else if (str.EndsWith("H"))
                    {
                        points *= 3;
                    }
                    else if (str.EndsWith("D"))
                    {
                        points *= 2;
                    }
                    else if (str.EndsWith("C"))
                    {
                        points *= 1;
                    }
                    ////
                    if (!playerPoints.ContainsKey(kvp.Key))
                    {
                        playerPoints[kvp.Key] = points;
                    }
                    else
                    {
                        playerPoints[kvp.Key] += points;
                    }

                    points = 0;
                }
            }

            foreach (KeyValuePair<string, int> kvp in playerPoints)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}