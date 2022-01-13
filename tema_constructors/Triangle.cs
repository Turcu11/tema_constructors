using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_constructors
{
    public class Triangle
    {
        Point A { get; set; }
        Point B { get; set; }
        Point C { get; set; }

        public Triangle(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public void Print()
        {
            Console.WriteLine($"A {this.A.X} {this.A.Y}");
            Console.WriteLine($"B {this.B.X} {this.B.Y}");
            Console.WriteLine($"C {this.C.X} {this.C.Y}");
        }

        public void Move(int dx, int dy)
        {
            this.A.X = this.A.X + dx;
            this.A.Y = this.A.Y + dy;
            this.B.X = this.B.X + dx;
            this.B.Y = this.B.Y + dy;
            this.C.X = this.C.X + dx;
            this.C.Y = this.C.Y + dy;
        }
    }
}