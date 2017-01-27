namespace _01.DayOfWeek
{
    using System;

    public class DayOfWeek
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = n <= 7 && n >= 1 ? DayName()[n] : DayName()[0];

            Console.WriteLine(result);
        }

        public static string[] DayName()
        {
            string[] dayNames = {"Invalid Day!",
                                 "Monday",
                                 "Tuesday",
                                 "Wednesday",
                                 "Thursday",
                                 "Friday",
                                 "Saturday",
                                 "Sunday"};

            return dayNames;
        }
    }
}