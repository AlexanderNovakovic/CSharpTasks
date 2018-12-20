using System;
using System.Collections.Generic;
using static System.Math;

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

        public double[] Solve()
        {
            List<double> solutions = new List<double>();

            for (double x = XMin; x <= XMax; x += DX)
            {
                double y = (Pow(x, 2) - 2 * x - 2) / (Pow(x, 2) + 1);
                solutions.Add(y);
            }

            return solutions.ToArray();
        }
    }
}
