namespace _07.Andrey_and_billiard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HelpCoolGuy
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> foodAndDrinksPrices = new Dictionary<string, double>();

            char[] ignore = new char[] { '-' };
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(ignore, StringSplitOptions.RemoveEmptyEntries);
                string productName = input[0];
                double productPrice = Convert.ToDouble(input[1]);
            }

            List<Customers> students = new List<Customers>();
            ignore = new char[] { '-', ',' };

            int count = 0;
            while (true)
            {
                string[] input = Console.ReadLine().Split(ignore, StringSplitOptions.RemoveEmptyEntries);

                if (string.Join(" ", input) == "end of clients")
                {
                    break;
                }
                else
                {
                    string customerName = input[0];
                    string productName = input[1];
                    int productQuanitity = Convert.ToInt32(input[2]);

                    if (!foodAndDrinksPrices.ContainsKey(productName))
                    {
                        students[count].Name = input[0];
                        students[count].Purchases.Add(productName, productQuanitity);
                    }
                }
            }
        }
    }
}
