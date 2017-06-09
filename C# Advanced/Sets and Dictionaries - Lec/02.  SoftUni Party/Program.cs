using System;
using System.Collections.Generic;
using System.Linq;

public class SoftUniParty
{
    public static void Main(string[] args)
    {
        var invitedGuests = new SortedSet<string>();

        while(true)
        {
            string input = Console.ReadLine();

            if(input != "PARTY")
            {
                invitedGuests.Add(input);
            }
            else
            {
                break;
            }
        }

        while(true)
        {
            string input = Console.ReadLine();

            if(input == "END")
            {
                break;
            }
            else if(invitedGuests.Contains(input))
            {
                invitedGuests.Remove(input);
            }
        }

        Console.WriteLine(invitedGuests.Count());

        foreach(string str in invitedGuests.Where(x => Char.IsDigit(x[0])))
        {
            Console.WriteLine(str);
        }

        foreach (string str in invitedGuests.Where(x => Char.IsLetter(x[0])))
        {
            Console.WriteLine(str);
        }
    }
}