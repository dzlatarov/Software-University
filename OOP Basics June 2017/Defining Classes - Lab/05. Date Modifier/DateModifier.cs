using System;
using System.Globalization;

public class DateModifier
{
    private DateTime dateOne;
    private DateTime dateTwo;

    public DateModifier(string dateOne, string dateTwo)
    {
        this.dateOne = DateTime.ParseExact(dateOne, "yyyy MM dd", CultureInfo.InvariantCulture); 
        this.dateTwo = DateTime.ParseExact(dateTwo, "yyyy MM dd", CultureInfo.InvariantCulture); 
    }

    public double FindDifferenceInDays()
    {
        return Math.Abs((this.dateOne - this.dateTwo).TotalDays);
    }
}

