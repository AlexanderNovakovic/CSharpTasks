using System;
using System.Collections.Generic;

namespace Task2_3
{
    public static class MathExtensions
    {
        public static double[] Solve(double dX, double dY, double d)
        {
            Validations(dX, dY, d);

            List<double> result = new List<double>();

            double x = dX / d;
            result.Add(x);

            double y = dY / d;
            result.Add(y);

            return result.ToArray();                                        
        }

        public static void Validations(double dX, double dY, double d)
        {
            if (d == 0)
                throw new ArgumentException("System is inconsistent.");

            if (d != 0 && dX == 0 && dY == 0)
                throw new ArgumentException("System is undetermined.");
        }

        public static double Determinant(double a1, double a2, double b1, double b2) =>
            a1 * b2 - a2 * b1;

        public static double DeterminatX(double b1, double b2, double c1, double c2) =>
            c1 * b2 - c2 * b1;

        public static double DeterminantY(double a1, double a2, double c1, double c2) =>
            a1 * c2 - a2 * c1;
    }
}
