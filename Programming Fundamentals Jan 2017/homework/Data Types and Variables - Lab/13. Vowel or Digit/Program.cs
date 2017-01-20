using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());

            if (char.IsDigit(n))
            {
                Console.WriteLine("digit");
            }
            else 
            {
                switch (n)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        Console.WriteLine("vowel");
                        break;

                    default:
                        Console.WriteLine("other");
                        break;
                }
            }
        }
    }
}
