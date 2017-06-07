using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReverseString
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        

        Console.WriteLine($"{input.PadRight(20, '*').Substring(0, 20)}");
    }
}