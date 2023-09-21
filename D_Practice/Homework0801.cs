using System;

namespace C_OOP
{
    // Homework0801
    internal class Complex
    {
        public double Imaginary { get; private set; }
        public double Real { get; private set; }
        public Complex(double real, double imaginary)
        {
            Imaginary = imaginary;
            Real = real;
        }

        public static Complex Plus(Complex first, Complex second)
        {
            return new Complex(first.Real + second.Real, first.Imaginary + second.Imaginary);
        }

        public static Complex Minus(Complex first, Complex second)
        {
            return new Complex(first.Real - second.Real, first.Imaginary - second.Imaginary);
        }

        public Complex Plus(Complex second)
        {
            return new Complex(this.Real + second.Real, this.Imaginary + second.Imaginary);
        }

        public Complex Minus(Complex second)
        {
            return new Complex(this.Real - second.Real, this.Imaginary - second.Imaginary);
        }
    }
}