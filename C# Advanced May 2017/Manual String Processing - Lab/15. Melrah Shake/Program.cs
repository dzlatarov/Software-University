using System;
using System.Text.RegularExpressions;

public static class MelrahShake
{
    public static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string shakePattern = Console.ReadLine();

        

        while (true)
        {
            if (shakePattern == string.Empty)
            {
                Console.WriteLine("No shake.");

                break;
            }
            var matcher = new Regex(Regex.Escape(shakePattern));
            
            if (matcher.IsMatch(text))
            {
                text = matcher.Replace(text, string.Empty, 1);

                int place = text.LastIndexOf(shakePattern);
                text = text.Remove(place, shakePattern.Length).Insert(place, string.Empty);

                Console.WriteLine("Shaked it.");

              shakePattern = shakePattern.Remove(shakePattern.Length / 2, 1);
            }
            else
            {
                Console.WriteLine("No shake.");

                break;
            }
        }

        Console.WriteLine(text);
    }
}