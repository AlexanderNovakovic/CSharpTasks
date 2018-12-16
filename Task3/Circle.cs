using System;

namespace Task3
{
    public class Circle
    {
        public double CalculateCircumference(double r) => Math.Round((2 * r * Math.PI), 2);

        public double CalculateArea(double r) => Math.Round((Math.Pow(r, 2) * Math.PI), 2);
    }
}
