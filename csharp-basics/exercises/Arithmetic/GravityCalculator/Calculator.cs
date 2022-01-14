using System;

namespace GravityCalculator
{
    public class Calculator
    {
        public double GravCalculator(double gravity, double fallingTime, double initialVelocity, double initialPosition)
        {
            return 0.5 * gravity * Math.Pow(fallingTime, 2) + initialVelocity * fallingTime + initialPosition;
        }
    }
}
