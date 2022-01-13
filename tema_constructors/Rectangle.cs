using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_constructors
{
    public class Rectangle
    {
        Point A { get; set; }
        Point B { get; set; }
        Point C { get; set; }
        Point D { get; set; }
        int latura1 { get; set; }
        int latura2 { get; set; }

        public Rectangle(Point A, int latura1, int latura2)
        {
            this.A = A;
            this.latura1 = latura1;
            this.latura2 = latura2;
            this.B.X = this.A.X + latura1;
            this.B.Y = this.A.Y;
            this.C.X = this.A.X;
            this.C.Y = this.A.Y + latura2;
            this.D.X = this.B.X;
            this.D.Y = this.C.Y;
        }
        public Rectangle(Point A, Point D)
        {
            this.A = A;
            this.D = D;
            this.B.X = this.A.X;
            this.B.Y = this.D.Y;
            this.C.X = this.D.X;
            this.C.Y = this.A.Y;
        }

        public void PrintRectangle()
        {
            Console.WriteLine($"A {this.A.X} {this.A.Y}");
            Console.WriteLine($"B {this.B.X} {this.B.Y}");
            Console.WriteLine($"C {this.C.X} {this.C.Y}");
            Console.WriteLine($"D {this.D.X} {this.D.Y}");
            Console.WriteLine($"Latura1 = {latura1}");
            Console.WriteLine($"Latura2 = {latura2}");
        }

        public void Move(int dx, int dy)
        {
            this.A.X = this.A.X + dx;
            this.A.Y = this.A.Y + dy;
            this.B.X = this.B.X + dx;
            this.B.Y = this.B.Y + dy;
            this.C.X = this.C.X + dx;
            this.C.Y = this.C.Y + dy;
            this.D.X = this.D.X + dx;
            this.D.Y = this.D.Y + dy;
        }
    }
}