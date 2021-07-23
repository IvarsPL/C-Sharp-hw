using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5,2);
            Point p2 = new Point(-3, 6);

            Console.WriteLine($"({p1.P1},{p1.P2})");
            Console.WriteLine($"({p2.P1},{p2.P2})");
            SwapPoint(p1, p2);
            Console.WriteLine($"({p1.P1},{p1.P2})");
            Console.WriteLine($"({p2.P1},{p2.P2})");
        }

        public static void SwapPoint(Point p, Point z)
        {
            var useless = p.P1;
            var uselessTwo = p.P2;
            var uselessThree = z.P1;
            var uselessFour = z.P2;
            p.P1 = uselessThree;
            p.P2 = uselessFour;
            z.P1 = useless;
            z.P2 = uselessTwo;

        }
    }
}
