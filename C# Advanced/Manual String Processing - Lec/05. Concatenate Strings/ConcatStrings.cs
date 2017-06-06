using System;
using System.Text;

public class ConcatStrings
{
    public static void Main(string[] args)
    {
        int numberOfInputs = int.Parse(Console.ReadLine());

        StringBuilder inputs = new StringBuilder();

        for(int i = 0; i < numberOfInputs; i++)
        {
            string input = Console.ReadLine();

            inputs.Append(string.Concat(input, " "));
        }

        Console.WriteLine(inputs.ToString());
    }
}