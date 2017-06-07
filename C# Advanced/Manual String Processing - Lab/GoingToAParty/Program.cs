using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class DjorAndDjango
{
    public static void Main(string[] args)
    {
        string path = Console.ReadLine();

        int position = 0;

        foreach (var c in path)
        {
            if (c == '^')
            {
                position = 0;

                if (position < 0 || position > path.Length - 1)
                {
                    break;
                }
            }



            if (char.IsLower(c))
                {
                    position += c - 96;

                    Console.WriteLine(position);
                }
                else if (char.IsUpper(c))
                {
                    position -= c - 64;

                    Console.WriteLine(position);
                }
            

        }

        if (position < 0 || position > path.Length - 1)
        {
            Console.WriteLine("Djor and Djano are lost at {0}!", position);
        }
        else
        {
            Console.WriteLine("Djor and Djano are at the party at {0}!", position);
        }
    }
}