using System;
using System.Linq;

public static class FirstName
{
    public static void Main(string[] args)
    {
        var names = Console.ReadLine()
            .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        var filter = Console.ReadLine()
            .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
            .OrderBy(x => x)
            .ToList();

        var hasMatch = false;

        foreach (var c in filter)
        {
            foreach (var name in names)
            {
                if (name.ToLower().StartsWith(c.ToLower()))
                {
                    Console.WriteLine(name.First().ToString().ToUpper() + String.Join("", name.Skip(1)));
                    hasMatch = true;
                    break;
                }
            }

            if (hasMatch)
            {
                break;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("No match");
        }
    }
}