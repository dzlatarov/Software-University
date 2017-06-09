namespace _11.GeometryCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GeometryCalculator
    {
        public static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            switch (figureType)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:0.00}", TriangleArea(side, height));
                    break;

                case "square":
                    double sideSquare = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:0.00}", SquareArea(sideSquare));
                    break;

                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double heightRectangle = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:0.00}", RectangleArea(width, heightRectangle));
                    break;

                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:0.00}", CircleArea(radius));
                    break;
            }
        }

        public static double TriangleArea(double side, double height)
        {
            double triangleFace = (side * height) / 2;
            return triangleFace;
        }

        public static double SquareArea(double sideSquare)
        {
            double squareFace = sideSquare * sideSquare;
            return squareFace;
        }

        public static double RectangleArea(double width, double heightRectangle)
        {
            double rectangleFace = width * heightRectangle;
            return rectangleFace;
        }

        public static double CircleArea(double radius)
        {
            double circleArea = Math.PI * radius * radius;
            return circleArea;
        }
    }
}