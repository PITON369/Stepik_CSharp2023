using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP
{
    internal class Homework0507
    {
        internal double CalcTriangleSquare(double ab, double bc, double ac)
        {
            double p = (ab + bc + ac) / 2;

            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
        }

        internal double CalcTriangleSquare(double b, double h)
        {
            return 0.5 * b * h;
        }
        internal double CalcTriangleSquare(double ab, double ac, int alpha, bool isInRadians = false)
        {
            if (isInRadians)
            {
                return 0.5 * ab * ac * Math.Sin(alpha);
            }
            else
            {
                double rads = alpha * Math.PI / 180;
                return 0.5 * ab * ac * Math.Sin(rads);
            }
        }
    }
}
