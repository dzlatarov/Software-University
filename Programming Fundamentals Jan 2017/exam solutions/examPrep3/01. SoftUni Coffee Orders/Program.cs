namespace _01.SoftUni_Coffee_Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class SoftUniCoffee
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<decimal> results = new List<decimal>();
            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long daysInMonth = Convert.ToInt64(DateTime.DaysInMonth(date.Year, date.Month));
                long capsulesCount = long.Parse(Console.ReadLine());

                decimal result = ((decimal) daysInMonth * capsulesCount) * pricePerCapsule;
                results.Add(result);
            }

            foreach(decimal result in results)
            {
                Console.WriteLine($"The price for the coffee is: ${Math.Round(result, 2):F2}");
            }

            Console.WriteLine($"Total: ${Math.Round(results.Sum(), 2):F2}");
        }
    }
}