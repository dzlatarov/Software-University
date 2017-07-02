using System;
using System.Text.RegularExpressions;

public static class LittleJohn
{
    public static void Main(string[] args)
    {
        var input = new string[4];

        for (int i = 0; i < 4; i++)
        {
            input[i] = Console.ReadLine();
        }

        var text = String.Join("\n", input);

        var smallArrow = new Regex(@">{1}-{5}>{1}");
        var mediumArrow = new Regex(@">{2}-{5}>{1}");
        var largeArrow = new Regex(@">{3}-{5}>{2}");
        var removeArrows = new Regex(@">{4,}-{5}>{3,}");

        text = removeArrows.Replace(text, string.Empty);

        var largeArrowCount = largeArrow.Matches(text).Count;
        text = largeArrow.Replace(text, string.Empty);
        var mediumArrowCount = mediumArrow.Matches(text).Count;
        text = mediumArrow.Replace(text, string.Empty);
        var smallArrowCount = smallArrow.Matches(text).Count;

        var decNumber = int.Parse($"{smallArrowCount}{mediumArrowCount}{largeArrowCount}");

        var binaryNumber = Convert.ToString(decNumber, 2);
        char[] binaryNumnberToCharrArray = binaryNumber.ToCharArray();
        Array.Reverse(binaryNumnberToCharrArray);
        string binaryNumberReversed = string.Join(string.Empty, binaryNumnberToCharrArray);

        var binaryNumberMirror = string.Concat(binaryNumber, binaryNumberReversed);
       

        Console.WriteLine(Convert.ToInt32(binaryNumberMirror, 2));        
    }
}