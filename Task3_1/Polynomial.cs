using System;
using System.Collections.Generic;
using static Task3_1.DoubleExtensions;

namespace Task3_1
{
    public class Polynomial
    {
        public double XMin { get; }
        public double XMax { get; }
        public double DX { get; }

        public Polynomial(double xMin, double xMax, double dX)
        {
            Validate(xMin, xMax, dX);

            XMin = xMin;
            XMax = xMax;
            DX = dX;
        }

        private static void Validate(double xMin, double xMax, double dX)
        {
            if (dX <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(dX));
            }

            if (xMin >= xMax)
            {
                throw new ArgumentOutOfRangeException(nameof(xMin));
            }
        }

        public double[] Solve(double[] coefficients, int n)
        {
            if (coefficients.Length != n + 1)
            {
                throw new ArgumentOutOfRangeException(nameof(coefficients));
            }

            List<double> result = new List<double>();

            for (double x = XMin; x <= XMax; x += DX)
            {
                result.Add(Sum(coefficients, x, n));
            }

            return result.ToArray();
        }
    }
}
