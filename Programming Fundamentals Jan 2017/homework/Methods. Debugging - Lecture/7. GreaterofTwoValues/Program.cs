namespace _7.GreaterofTwoValues
{
    using System;


    public class Program
    {
        public static void Main(string[] args)
        {
            string type = Console.ReadLine();
            object result = null;

            switch (type)
            {
                case "int":
                    {
                        int first = int.Parse(Console.ReadLine());
                        int second = int.Parse(Console.ReadLine());
                        result = GetMax(first, second);
                        break;
                    }

                case "char":
                    {
                        char first = char.Parse(Console.ReadLine());
                        char second = char.Parse(Console.ReadLine());
                        result = GetMax(first, second);
                        break;
                    }

                case "string":
                    {
                        string first = Console.ReadLine();
                        string second = Console.ReadLine();
                        result = GetMax(first, second);
                        break;
                    }
            }
            Console.WriteLine(result);

        }

        public static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        public static char GetMax(char first, char second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        public static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
