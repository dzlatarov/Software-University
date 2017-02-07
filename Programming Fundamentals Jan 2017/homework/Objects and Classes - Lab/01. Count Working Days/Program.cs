namespace _01.Count_Working_Days
{
    using System;
    using System.Globalization;

    public class CountWorkingDays
    {
        public static void Main(string[] args)
        {
            DateTime dateOne = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            DateTime dateTwo = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);

            int count = 0;
      
            for (DateTime i = dateOne; i <= dateTwo; i = i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
                {
                }
                else if (i.Month == 1 && i.Day == 1)
                {
                }
                else if (i.Month == 3 && i.Day == 3)
                {
                }
                else if (i.Month == 5 && i.Day == 1)
                {
                }
                else if (i.Month == 5 && i.Day == 6)
                {
                }
                else if (i.Month == 5 && i.Day == 24)
                {
                }
                else if (i.Month == 9 && i.Day == 6)
                {
                }
                else if (i.Month == 9 && i.Day == 22)
                {
                }
                else if (i.Month == 11 && i.Day == 1)
                {
                }
                else if (i.Month == 12 && i.Day == 24)
                {
                }
                else if (i.Month == 12 && i.Day == 25)
                {
                }
                else if (i.Month == 12 && i.Day == 26)
                {
                }
                else
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}