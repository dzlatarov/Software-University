namespace _07.Andrey_and_billiard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HelpCoolGuy
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> productPrice = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string[] productPriceInput = Console.ReadLine().Split('-').ToArray();
                string product = productPriceInput[0];
                double price = double.Parse(productPriceInput[1]);

                productPrice[product] = price;
            }

            Dictionary<string, Dictionary<string, int>> customerOrders = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] customerOrdersInput = Console.ReadLine().Split('-', ',').ToArray();

                if (string.Join(" ", customerOrdersInput) == "end of clients")
                {
                    break;
                }
                else
                {
                    string customerName = customerOrdersInput[0];
                    string orderName = customerOrdersInput[1];
                    int orderQuantity = Convert.ToInt32(customerOrdersInput[2]);

                    if (productPrice.ContainsKey(orderName))
                    {
                        Dictionary<string, int> orderNameAndQuantity = new Dictionary<string, int>();
                        if (!customerOrders.ContainsKey(customerName))
                        {
                            orderNameAndQuantity[orderName] = orderQuantity;
                            customerOrders[customerName] = orderNameAndQuantity;
                        }
                        else
                        {
                            orderNameAndQuantity = customerOrders[customerName];

                            if (!orderNameAndQuantity.ContainsKey(orderName))
                            {
                                orderNameAndQuantity[orderName] = orderQuantity;
                            }
                            else
                            {
                                orderNameAndQuantity[orderName] += orderQuantity;
                            }

                            customerOrders[customerName] = orderNameAndQuantity;
                        }
                    }
                }
            }
            double bill = 0;
            double totalBill = 0;
            foreach (var kvp in customerOrders.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var kvpTwo in kvp.Value)
                {
                    if (productPrice.ContainsKey(kvpTwo.Key))
                    {
                        Console.WriteLine($"-- {kvpTwo.Key} - {kvpTwo.Value}");
                        bill += productPrice[kvpTwo.Key] * kvpTwo.Value;
                    }
                }
                Console.WriteLine($"Bill: {bill:F2}");
                totalBill += bill;
                bill = 0;
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }
    }
}