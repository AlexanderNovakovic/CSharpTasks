using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Task4_2
{
    public class Triangle
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            Validate(a, b, c);

            A = a;
            B = b;
            C = c;
        }

        public double Surface()
        {
            double s = Circumference() / 2;

            return Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public double Circumference() => 
            A + B + C;

        private void Validate(double a, double b, double c)
        {
            if (a <= 0 && b <= 0 && c <= 0 && a + b <= c && a + c <= b && b + c <= a)
                throw new ArgumentOutOfRangeException("Invalid input.");
        }
    }
}
