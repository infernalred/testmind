using System;

namespace Shaper
{
    public class Circle : IShape
    {
        public double Radius { get; }


        public Circle(double radius)
        {
            Radius = radius;
        }
        
        public double Square()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }
}