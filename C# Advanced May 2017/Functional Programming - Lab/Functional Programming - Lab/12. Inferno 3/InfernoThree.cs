using System;
using System.Collections.Generic;
using System.Linq;

public static class InfernoThree
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var filters = new List<string>();

        while (true)
        {
            var command = Console.ReadLine();

            if (command == "Forge")
            {
                break;
            }

            var tokens = command
                .Split(new char[] { ';' }, 2, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var actions = tokens[0];
            var subFilter = tokens[1];

            if (actions == "Exclude")
            {
                filters.Add(subFilter);
            }
            else if (actions == "Reverse")
            {
                for (int i = filters.Count - 1; i >= 0; i--)
                {
                    if (filters[i] == subFilter)
                    {
                        filters.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        foreach (var filter in filters)
        {
            var helperList = new List<int>();

            var tokens = filter
                .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var command = tokens[0]
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var parameter = int.Parse(tokens[1]);

            if (command.Contains("Left") && command.Contains("Right"))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    int sum;

                    if (numbers.Count - 1 == 0)
                    {
                        sum = numbers[i];
                    }
                    else if (i == 0)
                    {
                        sum = numbers[i] + numbers[i + 1];
                    }
                    else if (i == numbers.Count - 1)
                    {
                        sum = numbers[i - 1] + numbers[i];
                    }
                    else
                    {
                        sum = numbers[i - 1] + numbers[i] + numbers[i + 1];
                    }

                    if (sum != parameter)
                    {
                        helperList.Add(numbers[i]);
                    }
                }
            }
            else if (command.Contains("Left"))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    int sum;

                    if (i == 0 || numbers.Count - 1 == 0)
                    {
                        sum = numbers[i];
                    }
                    else
                    {
                        sum = numbers[i - 1] + numbers[i];
                    }

                    if (sum != parameter)
                    {
                        helperList.Add(numbers[i]);
                    }
                }
            }
            else if (command.Contains("Right"))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    int sum;

                    if (i == numbers.Count - 1)
                    {
                        sum = numbers[i];
                    }
                    else
                    {
                        sum = numbers[i + 1] + numbers[i];
                    }

                    if (sum != parameter)
                    {
                        helperList.Add(numbers[i]);
                    }
                }
            }

            numbers = helperList.Select(x => x).ToList();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}