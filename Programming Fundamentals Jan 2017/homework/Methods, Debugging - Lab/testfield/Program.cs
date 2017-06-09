using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testfield
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            string number = i.ToString();
            string reversedNumber = new string(number.Reverse().ToArray());

            if (number == reversedNumber)
            {
                Console.WriteLine(i);
            }
        }
    }
}
