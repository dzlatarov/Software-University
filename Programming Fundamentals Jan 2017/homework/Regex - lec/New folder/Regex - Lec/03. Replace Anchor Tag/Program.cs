namespace _03.Replace_Anchor_Tag
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ReplaceAnchor
    {
        public static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder();
            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "end")
                {
                    break;
                }
                else
                {
                    input.Append(inputLine);
                }
            }

            string finalInput = input.ToString();

            string result = Regex.Replace(finalInput, @"<a.*?href.*?=(.*?)>(.*?)<\/a>", @"[URL href=$1]$2[/URL]");

            Console.WriteLine(result);
        }
    }
}