using System;

namespace _1.Blank_Receipt
{
    class Program
    {
        static void Header()
        {
            Console.WriteLine(@"CASH RECEIPT
------------------------------");
        }

        static void Body()
        {
            Console.WriteLine(@"Charged to____________________
Received by___________________");
        }

        static void Footer()
        {
            Console.WriteLine(@"------------------------------
© SoftUni");
        }

        static void Main(string[] args)
        {
            Header();
            Body();
            Footer();            
        }
    }
}

