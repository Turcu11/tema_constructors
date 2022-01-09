using System;

namespace tema_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(1, 6);
            point.PrintPoint();
            Console.WriteLine("New location of the point");
            point.MovePoint(10, 13);
            point.PrintPoint();
            Console.WriteLine();

            Triangle triangle = new Triangle(4, 8, 6, 2, 7, 10);
            Console.WriteLine("The points of the triangle");
            triangle.PrintTriangle();
            Console.WriteLine("New location of triangle");
            triangle.MoveTriangle(110, 150, 78, 90, 68, 13);
            triangle.PrintTriangle();
            Console.WriteLine();

            Console.WriteLine("***Rectangle***");
            Rectangle rectangle = new Rectangle(7, 7, 11, 9, "Usless");
            rectangle.PrintRectangle();
        }
    }
}