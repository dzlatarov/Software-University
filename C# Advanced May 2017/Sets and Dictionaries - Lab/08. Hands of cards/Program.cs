using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HandsOfCards
{
    public static void Main(string[] args)
    {
        var nameScore = new Dictionary<string, List<string>>();

        var cardValues = new Dictionary<string, int>();

        

        int[] types = new int[] { 11, 12, 13, 14 };
        char[] typesLetter = new char[] { 'J', 'Q', 'K', 'A' };
        int[] power = new int[] { 1, 2, 3, 4 };
        char[] powerLetter = new char[] { 'C', 'D', 'H', 'S' };

        for (int i = 2; i <= 10; i++)
        {
            for(int k = 0; k < 4; k++)
            {
                string combo = string.Concat($"{i}", powerLetter[k]);
                int points = i * power[k];
                cardValues.Add(combo, points);
            }           
        }

        for (int i = 0; i < 4; i++)
        {
           for(int k = 0; k < 4; k++)
            {
                string combo = string.Concat(typesLetter[i], powerLetter[k]);
                int points = types[i] * power[k];

                cardValues.Add(combo, points);
            }
        }

        while(true)
        {
            string[] input = Console.ReadLine().Split(new char[] { ':' });

            if(input[0] == "JOKER")
            {
                break;
            }

            string name = input[0];
            string[] cardsDrawn = input[1].Trim().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();


            if(!nameScore.ContainsKey(name))
            {
                List<string> temp = new List<string>();

                foreach (string str in cardsDrawn)
                {
                    temp.Add(str);
                }

                nameScore.Add(name, temp);
            }
            else
            {
                foreach (string str in cardsDrawn)
                {
                    nameScore[name].Add(str);
                }
            }
        }

        var result = new Dictionary<string, int>();

        foreach(var kvp in nameScore)
        {
            int points = 0;
            foreach(string str in kvp.Value.Distinct())
            {
                points += cardValues[str];
            }

            string name = kvp.Key;

            result.Add(name, points);
        }

        foreach(var kvp in result.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
        {
            Console.WriteLine($"{kvp.Key}: { kvp.Value}");
        }
    }
}