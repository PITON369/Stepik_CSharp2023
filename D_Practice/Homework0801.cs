using System;

namespace C_OOP
{
    internal class Homework0801
    {
        internal double Foo(double ab, double bc, double ac)
        {
            double p = (ab + bc + ac) / 2;

            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
        }
    }
}
