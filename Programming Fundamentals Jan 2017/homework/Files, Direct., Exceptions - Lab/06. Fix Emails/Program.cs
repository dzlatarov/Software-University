
namespace _04.Fix_Emails
{
    using System.Collections.Generic;
    using System.IO;

    public class FixEmails
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();

            string[] input = File.ReadAllLines("input.txt");

            int i = 0;
            while (true)
            {
                string key = input[i];

                if (key == "stop")
                {
                    break;
                }
                else
                {
                    emails[key] = input[i + 1];
                }
                i += 2;
            }

            List<string> output = new List<string>();
            foreach (KeyValuePair<string, string> kvp in emails)
            {
                if (!kvp.Value.EndsWith("us") && !kvp.Value.EndsWith("uk"))
                {
                    output.Add($"{kvp.Key} -> {kvp.Value}");
                }
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}