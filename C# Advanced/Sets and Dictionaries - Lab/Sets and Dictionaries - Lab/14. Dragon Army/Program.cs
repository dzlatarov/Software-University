using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class DragonArmy
{
    public static void Main(string[] args)
    {
        int numberOfDragons = int.Parse(Console.ReadLine());

        var dragonsByType = new Dictionary<string, SortedDictionary<string, int[]>>();

        var matcher = new Regex(@"(.+) (.+) (\d+|null) (\d+|null) (\d+|null)");
        
        for(int i = 0; i < numberOfDragons; i++)
        {
            string input = Console.ReadLine();

            if(matcher.IsMatch(input))
            {
                var info = matcher.Match(input);

                string type = info.Groups[1].ToString();
                string name = info.Groups[2].ToString();
                string damageString = info.Groups[3].ToString();
                string healthString = info.Groups[4].ToString();
                string armorString = info.Groups[5].ToString();

                int[] stats = Stats(damageString, healthString, armorString);
               
                if(!dragonsByType.ContainsKey(type))
                {
                    dragonsByType.Add(type, new SortedDictionary<string, int[]>());
                }

                if(!dragonsByType[type].ContainsKey(name))
                {
                    dragonsByType[type].Add(name, new int[3]);
                }

                dragonsByType[type][name] = stats;
            }
        }

        var averageotalStats = new Dictionary<string, double[]>();

        foreach(var type in dragonsByType)
        {
            double totalDamage = 0;
            double totalHealth = 0;
            double totalArmor = 0;

            foreach (var dragon in type.Value)
            {
                totalDamage += dragon.Value[0];
                totalHealth += dragon.Value[1];
                totalArmor += dragon.Value[2];                
            }

            averageotalStats.Add(type.Key, new double[] { totalDamage / type.Value.Count(), totalHealth / type.Value.Count(), totalArmor / type.Value.Count() });
        }

        foreach(var type in dragonsByType)
        {
            Console.WriteLine($"{type.Key}::({averageotalStats[type.Key][0]:0.00}/{averageotalStats[type.Key][1]:0.00}/{averageotalStats[type.Key][2]:0.00})");

            foreach(var dragon in type.Value)
            {
                Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
            }
        }
    }

    public static int[] Stats(string damageString, string healthString, string armorString)
    {
        int damage;
        int health;
        int armor;

        if (damageString == "null")
        {
            damage = 45;
        }
        else
        {
            damage = int.Parse(damageString);
        }

        if (healthString == "null")
        {
            health = 250;
        }
        else
        {
            health = int.Parse(healthString);
        }

        if (armorString == "null")
        {
            armor = 10;
        }
        else
        {
            armor = int.Parse(armorString);
        }

        return new int[] { damage, health, armor };
    }
}