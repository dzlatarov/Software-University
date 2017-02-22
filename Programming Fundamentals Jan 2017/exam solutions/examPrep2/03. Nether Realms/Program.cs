namespace _03.Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Demons
    {
        public string demonName { get; set; }
        public long health { get; set; }
        public decimal damage { get; set; }
    }

    public class YOUFACEJARAXUS
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ', ',', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> demonNames = new List<string>();
            foreach(string str in input)
            {
                demonNames.Add(str.Trim());
            }


            var healthRegex = new Regex(@"[^\d|\+|\-|\*|\/|\.|\-]");
            var damageRegex = new Regex(@"[\+|\-][\d|+|[\d.\d]+|[\d|[\d.\d]+");
            var multiplierRegex = new Regex(@"[\/|\*]");

            var demons = new List<Demons>();
            foreach (string demonName in demonNames.Where(x => !x.Contains(' ')))
            {
                var matchesHealth = healthRegex.Matches(demonName);
                var matchesDamage = damageRegex.Matches(demonName);
                var matchesMultiplier = multiplierRegex.Matches(demonName);

                long health = 0;
                decimal damage = 0;

                foreach (Match matchHeath in matchesHealth)
                {
                    health += Convert.ToInt32(matchHeath.ToString()[0]);
                }

                foreach (Match matchDamage in matchesDamage)
                {
                    damage += decimal.Parse(matchDamage.ToString());
                }

                foreach (Match matchMultiplier in matchesMultiplier)
                {
                    if (matchMultiplier.ToString() == "*")
                    {
                        damage *= 2m;
                    }
                    else if (matchMultiplier.ToString() == "/")
                    {
                        damage /= 2m;
                    }
                }

                Demons demon = new Demons
                {
                    demonName = demonName,
                    damage = damage,
                    health = health
                };

                if (health != 0)
                {
                    demons.Add(demon);
                }
            }

            List<string> cancer = new List<string>();
            foreach (var demon in demons.OrderBy(x => x.demonName))
            {
                if (!cancer.Contains(demon.demonName))
                {
                    Console.WriteLine($"{demon.demonName} - {demon.health} health, {demon.damage:f2} damage");
                    cancer.Add(demon.demonName);
                }
            }
        }
    }
}