using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public static class ReplaceTag
{
    public static void Main(string[] args)
    {
        var strBuilderText = new StringBuilder();

        while (true)
        {
            var input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }

            strBuilderText.Append(input);
        }

        var text = strBuilderText.ToString();


    }
}

