using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_constructors
{
    public static class GeometryUtils
    {
        public static void Move(Point[] puncte, int dx, int dy)
        {
            for(int i = 0; i < puncte.Length; i++)
            {
                puncte[i].MovePoint(dx, dy);
            }
        }

        public static void Move(Triangle triunghi, int dx, int dy)
        {
            triunghi.Move(dx, dy);
        }

        public static void Move(Rectangle dreptunghi, int dx, int dy)
        {
            dreptunghi.Move(dx, dy);
        }

        public static void Print(Point[] puncte)
        {
            for(int i = 0; i < puncte.Length; i++)
            {

            }
        }
    }
}
