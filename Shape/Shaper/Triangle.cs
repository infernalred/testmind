using System;

namespace Shaper
{
    public class Triangle : IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (IsCorrectTriangle(a, b, c))
                throw new ArgumentException("Invalid size of triangle");
            
            A = a;
            B = b;
            C = c;
        }
        
        public double Square()
        {
            var p = (A + B + C) / 2;
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 2);
        }

        public bool IsRightTriangle() =>
            A * A + B * B == C * C || A * A + C * C == B * B || C * C + B * B == A * A;

        private static bool IsCorrectTriangle(double a, double b, double c) =>
            a <= 0 || b <= 0 || c <= 0 || a > b + c || b > a + c || c > a + b;
    }
}