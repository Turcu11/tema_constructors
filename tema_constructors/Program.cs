using System;

namespace tema_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(1, 6);
            point.PrintPoint();
            point.MovePoint(10, 13);
            point.PrintPoint();
        }
    }
}
