using System;
using System.Collections.Generic;

public class UniqueUsernames
{
    public static void Main(string[] args)
    {
        int usernamesCount = int.Parse(Console.ReadLine());

        var uniqueUsernames = new HashSet<string>();

        for(int i = 0; i < usernamesCount; i++)
        {
            uniqueUsernames.Add(Console.ReadLine());
        }

        foreach(string str in uniqueUsernames)
        {
            Console.WriteLine(str);
        }
    }
}