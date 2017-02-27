namespace _2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> broadcasts = new List<string>();
            List<string> messages = new List<string>();

            Regex regex = new Regex(@"(.+) <-> (.+)");
            Regex leftSideBroadcast = new Regex(@"^[0-9]+$");
            Regex leftSideMessage = new Regex(@"^[^0-9]+$");
            Regex rightSideZ = new Regex(@"^[0-9|a-zA-Z]+$");
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Hornet is Green")
                {
                    break;
                }
                else
                {
                    Match match = regex.Match(input);
                    if (match.Success)
                    {
                        string leftSide = match.Groups[1].Value;
                        string rightSide = match.Groups[2].Value;

                        Match leftSideBroadcastMatch = leftSideBroadcast.Match(leftSide);
                        Match leftSideMessageMatch = leftSideMessage.Match(leftSide);
                        Match rightSideMatch = rightSideZ.Match(rightSide);

                        if (leftSideBroadcastMatch.Success && rightSideMatch.Success) //message (fixed the lazy way)
                        {
                            string LeftSideReversed = new string(leftSide.Reverse().ToArray());

                            messages.Add($"{LeftSideReversed} -> {rightSide}");
                        }
                        else if (leftSideMessageMatch.Success && rightSideMatch.Success) //broadcast 
                        {
                            StringBuilder rightSideModified = new StringBuilder();
                            foreach (char c in rightSide)
                            {
                                if (char.IsLetter(c))
                                {
                                    if (char.IsUpper(c))
                                    {
                                        rightSideModified.Append(char.ToLower(c));
                                    }
                                    else
                                    {
                                        rightSideModified.Append(char.ToUpper(c));
                                    }
                                }
                                else
                                {
                                    rightSideModified.Append(c);
                                }                                
                            }
                            broadcasts.Add($"{rightSideModified} -> {leftSide}");
                        }
                    }
                }
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (string str in broadcasts)
                {
                    Console.WriteLine(str);
                }
            }

            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (string str in messages)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}