namespace _1.Blank_Receipt
{
    using System;

    class BlankReceipt
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

