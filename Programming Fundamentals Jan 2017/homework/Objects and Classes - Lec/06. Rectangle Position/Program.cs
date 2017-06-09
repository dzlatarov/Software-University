namespace _6.Rectangle_Position
{
    using System;
    using System.Linq;

    public class RectanglePosition
    {
        public static void Main(string[] args)
        {
            int[] rOneInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] rTwoInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Rectangle rOne = new Rectangle()
            {
                Left = rOneInput[0],
                Top = rOneInput[1],
                Width = rOneInput[2],
                Height = rOneInput[3],
            };

            Rectangle rTwo = new Rectangle()
            {
                Left = rTwoInput[0],
                Top = rTwoInput[1],
                Width = rTwoInput[2],
                Height = rTwoInput[3],
            };

            if (IsInside(rOne, rTwo))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        public static bool IsInside(Rectangle rOne, Rectangle rTwo)
        {
            if (rOne.Left >= rTwo.Left && rOne.Right <= rTwo.Right && rOne.Top <= rTwo.Top && rOne.Bottom <= rTwo.Bottom)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}