using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5,2);
            Point p2 = new Point(-3, 6);

            Console.WriteLine($"({p1.p1},{p1.p2})");
            Console.WriteLine($"({p2.p1},{p2.p2})");
            SwapPoint(p1, p2);
            Console.WriteLine($"({p1.p1},{p1.p2})");
            Console.WriteLine($"({p2.p1},{p2.p2})");
        }

        public static void SwapPoint(Point p, Point z)
        {
            var useless = p.p1;
            var uselessTwo = p.p2;
            var uselessThree = z.p1;
            var uselessFour = z.p2;
            p.p1 = uselessThree;
            p.p2 = uselessFour;
            z.p1 = useless;
            z.p2 = uselessTwo;

        }
    }
}
