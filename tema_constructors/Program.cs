using System;

namespace tema_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 6);
            Point point2 = new Point(4, 5);
            Point point3 = new Point(2, 8);
            point1.PrintPoint();
            Console.WriteLine("New location of the point");
            point1.MovePoint(10, 13);
            point1.PrintPoint();

            Triangle triunghi = new Triangle(point1, point2, point3);
            triunghi.Print();
            triunghi.Move(2, 2);
            triunghi.Print();

            Rectangle dreptunghi = new Rectangle(point1, 4, 5);
            dreptunghi.PrintRectangle();
        }
    }
}