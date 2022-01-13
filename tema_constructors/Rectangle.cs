using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_constructors
{
    public class Rectangle
    {
        int _point1X { get; set; }
        int _point1Y { get; set; }
        int _point2X { get; set; }
        int _point2Y { get; set; }
        int _point3X { get; set; }
        int _point3Y { get; set; }
        int _point4X { get; set; }
        int _point4Y { get; set; }

        public Rectangle(int point1x,int point1y, int side1, int side2)
        {
            this._point1X = point1x;
            this._point1Y = point1y;
            this._point2X = _point1X + side1;
            this._point2Y = _point1Y;
            this._point3X = _point1X;
            this._point3Y = _point1Y + side2;
            this._point4X = _point2X;
            this._point4Y = _point3Y;
        }

        public Rectangle(int point1x, int point1y, int point4x, int point4y, string useless)
        {
            this._point1X = point1x;
            this._point1Y = point1y;
            this._point4X = point4x;
            this._point4Y = point4y;
            this._point2X = _point4X;
            this._point2Y = _point1Y;
            this._point3X = _point1X;
            this._point3Y = _point4Y;
        }

        public void PrintRectangle()
        {
            Console.WriteLine($"Point1 = X({this._point1X}), Y({this._point1Y})");
            Console.WriteLine($"Point2 = X({this._point2X}), Y({this._point2Y})");
            Console.WriteLine($"Point3 = X({this._point3X}), Y({this._point3Y})");
            Console.WriteLine($"Point4 = X({this._point4X}), Y({this._point4Y})");
            Console.WriteLine($"Side 1 = {this._point2X - this._point1X}");
            Console.WriteLine($"Side 2 = {this._point3Y - this._point1Y}");
        }
        public void MoveRectangle()
        {
            
        }

    }
}