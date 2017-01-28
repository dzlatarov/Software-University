namespace _05.Compare_Char_Arrays
{
    using System;
    using System.Linq;

    public class ComapeCharArrays
    {
        public static void Main(string[] args)
        {
            char[] arrayOne = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arrayTwo = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int shorterArraySize = arrayOne.Length >= arrayTwo.Length ? arrayTwo.Length : arrayOne.Length;

            bool isEqual = true;

            for (int i = 0; i < shorterArraySize; i++)
            {
                if (arrayOne[i] < arrayTwo[i])
                {
                    Console.WriteLine(string.Join("", arrayOne));
                    Console.WriteLine(string.Join("", arrayTwo));
                    isEqual = false;
                    break;
                }
                else if (arrayOne[i] > arrayTwo[i])
                {
                    Console.WriteLine(string.Join("", arrayTwo));
                    Console.WriteLine(string.Join("", arrayOne));
                    isEqual = false;
                    break;
                }
            }

            if (isEqual)
            {
                if (arrayOne.Length >= arrayTwo.Length)
                {
                    Console.WriteLine(string.Join("", arrayTwo));
                    Console.WriteLine(string.Join("", arrayOne));
                }
                else
                {
                    Console.WriteLine(string.Join("", arrayOne));
                    Console.WriteLine(string.Join("", arrayTwo));
                }
            }
        }
    }
}