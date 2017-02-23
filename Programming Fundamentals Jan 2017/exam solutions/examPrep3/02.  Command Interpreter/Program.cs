namespace _02.Command_Interpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class CommandInterpreter
    {
        public static void Main(string[] args)
        {
            List<string> array = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                else if (Regex.IsMatch(input, @"^reverse from \d+ count \d+$"))
                {
                    ReverseFromToCount(array, input);
                }
                else if (Regex.IsMatch(input, @"^sort from \d+ count \d+$"))
                {
                    SortFromToCount(array, input);
                }
                else if (Regex.IsMatch(input, @"^rollLeft \d+ times$"))
                {
                    rollLeft(array, input);
                }
                else if (Regex.IsMatch(input, @"^rollRight \d+ times$"))
                {
                    rollRight(array, input);
                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                }
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        public static List<string> ReverseFromToCount(List<string> array, string input)
        {
            var matches = Regex.Matches(input, @"\d+");

            List<int> numbers = new List<int>();
            foreach (Match match in matches)
            {
                numbers.Add(Convert.ToInt32(match.ToString()));
            }

            int from = numbers[0];
            int count = numbers[1];

            if (from < 0 || from + count > array.Count - 1 || from >= count)
            {
                Console.WriteLine("Invalid input parameters.");
                return array;
            }
            else
            {
                List<string> range = new List<string>();
                for (int i = from; i < from + count; i++)
                {
                    range.Add(array[i]);
                }
                range.Reverse();

                array.RemoveRange(from, count);
                array.InsertRange(from, range);

                return array;
            }
        }

        public static List<string> SortFromToCount(List<string> array, string input)
        {
            var matches = Regex.Matches(input, @"\d+");

            List<int> numbers = new List<int>();
            foreach (Match match in matches)
            {
                numbers.Add(Convert.ToInt32(match.ToString()));
            }

            int from = numbers[0];
            int count = numbers[1];

            if (from < 0 || from + count > array.Count - 1 || from > count)
            {
                Console.WriteLine("Invalid input parameters.");
                return array;
            }
            else
            {
                List<string> range = new List<string>();
                for (int i = from; i < from + count; i++)
                {
                    range.Add(array[i]);
                }
                range.Sort();

                array.RemoveRange(from, count);
                array.InsertRange(from, range);

                return array;
            }
        }

        public static List<string> rollLeft(List<string> array, string input)
        {
            var matches = Regex.Matches(input, @"\d+");

            List<int> numbers = new List<int>();
            foreach (Match match in matches)
            {
                numbers.Add(Convert.ToInt32(match.ToString()));
            }

            int times = numbers[0];

            if (times < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return array;
            }
            else
            {
                for (int i = 0; i < times; i++)
                {
                    string zeroElement = array[0];
                    array.RemoveAt(0);
                    array.Add(zeroElement);
                }

                return array;
            }
        }

        public static List<string> rollRight(List<string> array, string input)
        {
            var matches = Regex.Matches(input, @"\d+");

            List<int> numbers = new List<int>();
            foreach (Match match in matches)
            {
                numbers.Add(Convert.ToInt32(match.ToString()));
            }

            int times = numbers[0];

            if (times < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return array;
            }
            else
            {
                for (int i = 0; i < times; i++)
                {
                    string lastElement = array[array.Count() - 1];
                    array.RemoveAt(array.Count() - 1);
                    array.Insert(0, lastElement);
                }

                return array;
            }
        }
    }
}