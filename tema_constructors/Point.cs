using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_constructors
{
    public class Point
    {
        public int XValue;
        public int YValue;
       
        public Point(int xValue, int yValue)
        {
            this.XValue = xValue;
            this.YValue = yValue;
        }

        public void PrintPoint()
        {
            Console.WriteLine($"{this.XValue} {this.YValue}");
        }

        public void MovePoint(int x, int y)
        {
            XValue = x;
            YValue = y;
        }
    }
}