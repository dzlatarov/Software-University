using System;
using System.Collections.Generic;

public class Phonebook
{
    public static void Main(string[] args)
    {
        var phonebook = new Dictionary<string, string>();

        while(true)
        {
            string[] input = Console.ReadLine().Split('-');

            if(input[0] == "search")
            {
                break;
            }
            else
            {
                if(phonebook.ContainsKey(input[0]))
                {
                    phonebook[input[0]] = input[1];
                }
                else
                {
                    phonebook.Add(input[0], input[1]);
                }
            }
        }

        while(true)
        {
            string input = Console.ReadLine();

            if(input == "stop")
            {
                break;
            }
            else if (phonebook.ContainsKey(input))
            {
                string name = input;
                string number = phonebook[input];

                Console.WriteLine($"{name} -> {number}");
            }
            else
            {
                Console.WriteLine($"Contact {input} does not exist.");
            }
        }
    }
}