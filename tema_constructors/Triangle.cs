using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_constructors
{
    public class Triangle
    {
        int _point1X { get; set; }
        int _point1Y { get; set; }
        int _point2X { get; set; }
        int _point2Y { get; set; }
        int _point3X { get; set; }
        int _point3Y { get; set; }

        public Triangle(int point1x, int point1y, int point2x, int point2y, int point3x, int point3y)
        {
            this._point1X = point1x;
            this._point1Y = point1y;
            this._point2X = point2x;
            this._point2Y = point2y;
            this._point3X = point3x;
            this._point3Y = point3y;
        }

        public void PrintTriangle()
        {
            Console.WriteLine($"Point1 = {this._point1X}, {this._point1Y}");
            Console.WriteLine($"Point2 = {this._point2X}, {this._point2Y}");
            Console.WriteLine($"Point3 = {this._point3X}, {this._point3Y}");
        }

        public void MoveTriangle(int p1x, int p1y, int p2x, int p2y, int p3x, int p3y)
        {
            this._point1X = p1x;
            this._point1Y = p1y;
            this._point2X = p2x;
            this._point2Y = p2y;
            this._point3X = p3x;
            this._point3Y = p3y;
        }
    }
}