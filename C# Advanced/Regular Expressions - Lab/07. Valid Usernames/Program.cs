using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public static class ValidUsernames
{
    public static void Main(string[] args)
    {
        string[] userNames = Console.ReadLine()
            .Split(new char[] {' ', '/', '(', ')', '\\'}, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        List<string> filteredUsernames = new List<string>();

        var matcher = new Regex(@"^[a-zA-Z][\w|\d|-]{2,24}$");

        foreach (var username in userNames)
        {
            if (matcher.IsMatch(username))
            {
                filteredUsernames.Add(username);
            }
        }

        int biggestLengthSum = 0;
        int biggestLengthSumIndex = 0;

        for (int i = 0; i < filteredUsernames.Count - 1; i++)
        {
            int currentLength = filteredUsernames[i].Length + filteredUsernames[i + 1].Length;

            if (currentLength > biggestLengthSum)
            {
                biggestLengthSum = currentLength;
                biggestLengthSumIndex = i;
            }
        }

        Console.WriteLine(filteredUsernames[biggestLengthSumIndex]);
        Console.WriteLine(filteredUsernames[biggestLengthSumIndex + 1]);
    }
}