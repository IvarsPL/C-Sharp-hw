using System;

namespace CalculateArea
{
    public class CalculateArea
    {
        static void Main(string[] args)
        {
            int choice; // The user's menu choice

            do
            {
                // Get the user's menu choice.
                choice = GetMenu();

                if (choice == 1)
                {
                    Console.WriteLine("You chose Area of a Circle");
                    CalculateCircleArea();
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("You chose Area of a Rectangle");
                    CalculateRectangleArea();
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("You chose Area of a Triangle");
                    CalculateTriangleArea();
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thanks for calculating!");
                    Console.ReadKey();
                }

            } while (choice != 4);
        }

        public static int GetMenu()
        {

            int userChoice;

            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            userChoice = int.Parse(Console.ReadLine());



            if (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("Please enter a valid range: 1, 2, 3, or 4: ");
                userChoice = int.Parse(Console.ReadLine());
            }

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            Console.WriteLine("What is the circle's radius? ");
            var keyboard = Console.ReadLine();

            try
            {
                decimal.TryParse(keyboard, out var radius);

                Console.WriteLine("The circle's area is "
                        + Geometry.AreaOfCircle(radius));
            }
            catch (ArgumentOutOfRangeException e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public static void CalculateRectangleArea()
        {
            Console.WriteLine("Enter length? ");
            var keyboard = Console.ReadLine();
            try
            {
                decimal.TryParse(keyboard, out var length);

                Console.WriteLine("Enter width? ");

                keyboard = Console.ReadLine();
                decimal.TryParse(keyboard, out var width);

                Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfTriangle(length, width));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void CalculateTriangleArea()
        {
            Console.WriteLine("Enter length of the triangle's base? ");
            var keyboard = Console.ReadLine();

            try
            {
                decimal.TryParse(keyboard, out var ground);

                Console.WriteLine("Enter triangle's height? ");

                keyboard = Console.ReadLine();
                decimal.TryParse(keyboard, out var height);

                Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
