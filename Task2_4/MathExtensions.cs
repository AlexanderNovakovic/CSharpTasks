using static System.Math;
using System.Collections.Generic;

namespace Task2_4
{
    public static class MathExtensions
    {
        public static double[] SolveQuadraticEquation(double a, double b, double c)
        {
            List<double> result = new List<double>();

            if (a != 0)
            {
                double d = Pow(b, 2) - 4 * a * c;

                if (d > 0)
                {
                    double x1 = (-b + Sqrt(d)) / (2 * a);
                    result.Add(x1);

                    double x2 = (-b - Sqrt(d)) / (2 * a);
                    result.Add(x2);

                    return result.ToArray();
                }
                else if (d == 0)
                {
                    double x1 = -b / (2 * a);
                    result.Add(x1);

                    return result.ToArray();
                }
                else
                {
                    double x1 = -b / (2 * a);
                    result.Add(x1);

                    double y1 = Sqrt(-d) / (2 * a);
                    result.Add(y1);

                    double x2 = x1;
                    result.Add(x2);

                    double y2 = -y1;
                    result.Add(y2);

                    return result.ToArray();
                }
            }
            else if (b != 0)
            {
                double x1 = -c / b;
                result.Add(x1);

                return result.ToArray();
            }
            else
            {
                return null;
            }               
        }
    }
}
