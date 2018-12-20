using System;
using System.Collections.Generic;

namespace Task2_7
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

        public double[] Sum1(int n)
        {
            List<double> result = new List<double>();

            for (double x = XMin; x <= XMax; x += DX)
            {
                result.Add(x.SumOfPowers1(n));
            }

            return result.ToArray();
        }

        public double[] Sum2(int n)
        {
            List<double> result = new List<double>();

            for (double x = XMin; x <= XMax; x += DX)
            {
                result.Add(x.SumOfPowers2(n));
            }

            return result.ToArray();
        }
    }
}
