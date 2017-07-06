using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public static class CubicArtillery
{
    public static void Main(string[] args)
    {
        var maxCapcity = int.Parse(Console.ReadLine());

        var bunkers = new Queue<string>();
        var weapons = new Queue<int>();
        var leftCapcity = maxCapcity;

        string inputLine;
        while ((inputLine = Console.ReadLine()) != "Bunker Revision")
        {
            var tokens = inputLine.Split(' ');

            foreach (var elment in tokens)
            {
                int weapon;
                var isDigit = int.TryParse(elment, out weapon);

                if (!isDigit)
                {
                    bunkers.Enqueue(elment);
                }
                else
                {
                    var isSaved = false;
                    while (bunkers.Count > 1)
                    {
                        if (leftCapcity >= weapon)
                        {
                            weapons.Enqueue(weapon);
                            leftCapcity -= weapon;
                            isSaved = true;
                            break;
                        }


                        if (weapons.Count == 0)
                        {
                            Console.WriteLine($"{bunkers.Dequeue()} -> Empty");
                        }
                        else
                        {
                            Console.WriteLine($"{bunkers.Dequeue()} -> {string.Join(", ", weapons)}");
                        }
                        weapons.Clear();
                        leftCapcity = maxCapcity;
                    }

                    if (!isSaved)
                    {
                        if (weapon <= maxCapcity)
                        {

                            while (leftCapcity < weapon)
                                leftCapcity += weapons.Dequeue();

                            weapons.Enqueue(weapon);
                            leftCapcity -= weapon;
                        }
                    }
                }
            }
        }
    }
}