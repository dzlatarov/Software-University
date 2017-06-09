using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        var emailAndName = new Dictionary<string, string>();

        string name = string.Empty;
        
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
                name = input;
            }
            else if(counter % 2 == 1)
            {
                string email = input;

                if(!(email.EndsWith("us") || email.EndsWith("uk")))
                {
                    emailAndName.Add(name, email);
                }
            }
                

            counter++;
        }

        foreach (var kvp in emailAndName)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}

