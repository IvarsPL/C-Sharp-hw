using System;

namespace CalculateArea
{
    public static class Geometry
    {
        public static decimal AreaOfCircle(decimal radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException();
            var area = (decimal)Math.PI * radius * radius;
            return Math.Round(area, 2);
        }

        public static decimal AreaOfRectangle(decimal length, decimal width)
        {
            if (length < 0 || width < 0) throw new ArgumentOutOfRangeException();
            var area = (length * width);
            area = Decimal.Round(area, 2);
            return area;

        }

        public static decimal AreaOfTriangle(decimal ground, decimal h)
        {
            if (ground < 0 || h < 0) throw new ArgumentOutOfRangeException();
            var area = (decimal)0.5 * ground * h;
            area = Decimal.Round(area, 2);
            return area;
        }
    }
}
