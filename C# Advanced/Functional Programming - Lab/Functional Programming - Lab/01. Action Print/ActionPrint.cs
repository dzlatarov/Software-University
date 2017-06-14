using System;
using System.Linq;

public static class ActionPrint
{
    public static void Main(string[] args)
    {
        Action<string> MyAction = input => 
        Console.WriteLine(string.Join("\n", input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray()));

        MyAction(Console.ReadLine());
    }
}