using System;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            return decimal.ToDouble(radius * (decimal)Math.PI * 2);
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            return decimal.ToDouble(length * width);
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            return decimal.ToDouble(ground * h * 0.5m);
        }
    }
}
