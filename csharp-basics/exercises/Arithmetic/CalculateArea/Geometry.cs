using System;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            return decimal.ToInt32(radius * radius * (decimal)Math.PI);
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            return decimal.ToInt32(length * width);
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            return decimal.ToInt32(ground * h * 0.5m);
        }
    }
}
