using System;
using System.Collections.Generic;

public class MinersTask
{
    public static void Main(string[] args)
    {
        

        string resourceName = string.Empty;

        var resources = new Dictionary<string, int>();

        int counter = 0;
        while (true)
        {
            string input = Console.ReadLine();

            if(input == "stop")
            {
                break;
            }

            if(counter % 2 == 0)
            {
                resourceName = input;
            }
            else if(counter % 2 == 1)
            {
                int resourceQuantity = int.Parse(input);

                if(resources.ContainsKey(resourceName))
                {
                    resources[resourceName] += resourceQuantity;
                }
                else
                {
                    resources.Add(resourceName, resourceQuantity);
                }
            }

            counter++;
        }

        foreach(var kvp in resources)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}