using System;
using System.Collections.Generic;
using static System.Math;

namespace Task2_5
{
    public static class MathExtensions
    {
        public static double[] Solve(Equation equation)
        {
            List<double> solutions = new List<double>();

            double xMin = equation.XMin;
            double xMax = equation.XMax;
            double dX = equation.DX;

            if(Validate(xMin, xMax, dX))
            {
                for (double x = xMin; x <= xMax; x += dX)
                {
                    double y = (Pow(x, 2) - 2 * x - 2) / (Pow(x, 2) + 1);
                    solutions.Add(y);
                }
            }

            return solutions.ToArray();
        }

        public static bool Validate(double xMin, double xMax, double dX)
        {
            if (dX <= 0)
                throw new ArgumentOutOfRangeException(nameof(dX));

            if (xMin >= xMax)
                throw new ArgumentOutOfRangeException(nameof(xMin));

            return true;
        }
    }
}
