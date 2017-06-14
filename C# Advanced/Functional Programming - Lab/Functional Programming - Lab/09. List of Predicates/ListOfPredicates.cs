using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ListOfPredicates
{
    public static void Main(string[] args)
    {
        var length = int.Parse(Console.ReadLine());
        var devisors = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Distinct()
            .ToArray();

        Func<int, int[], List<int>> F = delegate(int count, int[] devisions)
        {
            var result = new List<int>();

            bool devisable = true;

            for (int i = 1; i <= count; i++)
            {
                foreach (var devision in devisions)
                {
                    if (i % devision != 0)
                    {
                        devisable = false;
                        break;
                    }
                }

                if (devisable)
                {
                    result.Add(i);
                }
                else
                {
                    devisable = true;
                }
            }


            return result;
        };


        Console.WriteLine(string.Join(" ", F(length, devisors)));
    }
}

