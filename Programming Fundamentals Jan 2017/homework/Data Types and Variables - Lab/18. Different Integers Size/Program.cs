using System;
using System.Collections.Generic;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            bool willFit = false;
            List<string> message = new List<string>();

            try
            {
                sbyte works = sbyte.Parse(number);
                willFit = true;
                message.Add("* sbyte");
            }
            catch(Exception)
            { 
            }

            try
            {
                byte works = byte.Parse(number);
                willFit = true;
                message.Add("* byte");
            }
            catch(Exception)
            {
            }

            try
            {
                short works = short.Parse(number);
                willFit = true;
                message.Add("* short");
            }
            catch (Exception)
            {
            }

            try
            {
                ushort works = ushort.Parse(number);
                willFit = true;
                message.Add("* ushort");
            }
            catch (Exception)
            {
            }

            try
            {
                int works = int.Parse(number);
                willFit = true;
                message.Add("* int");
            }
            catch (Exception)
            {
            }

            try
            {
                uint works = uint.Parse(number);
                willFit = true;
                message.Add("* uint");
            }
            catch (Exception)
            {
            }

            try
            {
                long works = long.Parse(number);
                willFit = true;
                message.Add("* long");
            }
            catch (Exception)
            {
            }

            try
            {
                ulong works = ulong.Parse(number);
                willFit = true;
                message.Add("* ulong");
            }
            catch (Exception)
            {
            }

            if (willFit)
            {
                foreach (string s in message)
                {
                    Console.WriteLine(s);
                }
            }
            else
            {
                Console.WriteLine("can't fit in any type");
            }
        }
    }
}
