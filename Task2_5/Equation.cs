using System;

namespace Task2_5
{
    public class Equation
    {
        public double XMin { get; }
        public double XMax { get; }
        public double DX { get; }

        public Equation(double xMin, double xMax, double dX)
        {
            Validate(xMin, xMax, dX);

            XMin = xMin;
            XMax = xMax;
            DX = dX;
        }

        public static void Validate(double xMin, double xMax, double dX)
        {
            if (dX <= 0)
                throw new ArgumentOutOfRangeException(nameof(dX));

            if (xMin >= xMax)
                throw new ArgumentOutOfRangeException(nameof(xMin));                    
        }
    }
}
