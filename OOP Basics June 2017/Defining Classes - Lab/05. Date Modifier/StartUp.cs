using System;

public static class StartUp
{
    public static void Main(string[] args)
    {
        var dateOne = Console.ReadLine();
        var dateTwo = Console.ReadLine();

        var datesToModify = new DateModifier(dateOne, dateTwo);

        var result = datesToModify.FindDifferenceInDays();
        Console.WriteLine(result);
    }
}

