namespace _01.Sweet_Dessert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SweetDesert
    {
        public static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var guests = long.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berryPrice = decimal.Parse(Console.ReadLine());

            var portions = guests / 6;
            if (guests > portions * 6)
            {
                portions++;
            }

            var pricePerPortion = 2m * bananaPrice + 4m * eggPrice + 0.2m * berryPrice;
            var totalPrice = pricePerPortion * portions;

            var moneyLeft = money - totalPrice;

            if(moneyLeft >= 0)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will neeed {Math.Abs(moneyLeft):f2} more");
            }
        }
    }
}
