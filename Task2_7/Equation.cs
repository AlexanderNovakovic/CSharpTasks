using System;

namespace Task2_7
{
    public class Equation
    {
        public double XMin { get; }
        public double XMax { get; }
        public double DX { get; }

        public Equation(double xMin, double xMax, double dX)
        {
            ValidateParameters(xMin, xMax, dX);

            XMin = xMin;
            XMax = xMax;
            DX = dX;
        }

        public static void ValidateParameters(double xMin, double xMax, double dX)
        {
            if (dX <= 0)
                throw new ArgumentOutOfRangeException(nameof(dX));

            if (xMin >= xMax)
                throw new ArgumentOutOfRangeException(nameof(xMin));
        }
    }
}
