using System;

namespace Task2_3
{

    public static class MathExtensions
    {
        public static EquationSoultion Solve(Equation first, Equation second)
        {
            double d = Determinant(first, second);
            double dX = DeterminatX(first, second);
            double dY = DeterminantY(first, second);

            ValidateDeterminants(d, dX, dY);

            return new EquationSoultion(dX / d, dY / d);
        }

        public static void ValidateDeterminants(double d, double dX, double dY)
        {
            if (d == 0)
                throw new ArgumentException("System is inconsistent.");

            if (d != 0 && dX == 0 && dY == 0)
                throw new ArgumentException("System is undetermined.");
        }

        public static double Determinant(Equation first, Equation second) =>
            first.A * second.B - second.A * first.B;

        public static double DeterminatX(Equation first, Equation second) =>
            first.C * second.B - second.C * first.B;

        public static double DeterminantY(Equation first, Equation second) =>
            first.A * second.C - second.A * first.C;
    }
}
