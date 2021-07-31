﻿
using System;

namespace GravityCalculator
{
    public class GravityCalculator
    {
        public static double FinalPosition(double gravity, double initialVelocity, double fallingTime, double initialPosition)
        {
            return 0.5 * (gravity * (fallingTime * fallingTime)) + (initialVelocity * fallingTime) + initialPosition;
        }
        static void Main(string[] args)
        {
            double gravity = -9.81;
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double finalPosition = FinalPosition(gravity, initialVelocity, fallingTime, initialPosition);

            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
    }
}