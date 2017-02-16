namespace _01.Extract_Emails
{
    using System;
    using System.Text.RegularExpressions;
    using System.Text;

    public class EmailExtractor
    {
        public static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                else
                {
                    if(input.EndsWith("."))
                    {
                        input = input.Remove(input.Length - 1);
                    }
                    str.Append(input);
                }
            }

            string finalString = str.ToString();

            char[] ignore = new char[] { ' ', ',' };
            string[] fuckingCancer = finalString.Split(ignore, StringSplitOptions.RemoveEmptyEntries);

            var regex = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

            foreach (string cancer in fuckingCancer)
            {
                if (regex.IsMatch(cancer))
                {
                    Console.WriteLine(cancer);
                }
            }
        }
    }
}