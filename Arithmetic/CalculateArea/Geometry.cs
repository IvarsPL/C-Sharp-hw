using System;

namespace CalculateArea
{
    public class Geometry
    {
        public static double areaOfCircle(decimal radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException();
            double area = Math.PI * ((double)radius * 2);
            return area;
        }

        public static double areaOfRectangle(decimal length, decimal width)
        {
            if (length < 0 || width < 0) throw new ArgumentOutOfRangeException();
            double area = (double)(length * width);
            return area;

        }

        public static double areaOfTriangle(decimal ground, decimal h)
        {
            if (ground < 0 || h < 0) throw new ArgumentOutOfRangeException();
            double area = (double)0.5 * (double)ground * (double)h;
            return area;
        }
    }
}
