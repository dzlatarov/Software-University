namespace _04.Fix_Emails
{
    using System;
    using System.Collections.Generic;

    public class FixEmails
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();

            while (true)
            {
                string key = Console.ReadLine();

                if (key == "stop")
                {
                    break;
                }
                else
                {
                    emails[key] = Console.ReadLine();
                }
            }

            foreach (KeyValuePair<string, string> kvp in emails)
            {
                if (!kvp.Value.EndsWith("us") && !kvp.Value.EndsWith("uk"))
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}