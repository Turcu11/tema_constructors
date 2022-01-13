using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_constructors
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
       
        public Point(int xValue, int yValue)
        {
            this.X = xValue;
            this.Y = yValue;
        }

        public void PrintPoint()
        {
            Console.WriteLine($"{this.X} {this.Y}");
        }

        public void MovePoint(int x, int y)
        {
            this.X = X + x;
            this.Y = Y + y;
        }
    }
}