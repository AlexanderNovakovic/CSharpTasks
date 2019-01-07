using System;

namespace Task4_6
{
    public class RationalNumber
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentNullException(nameof(denominator));
            }

            Numerator = numerator;
            Denominator = denominator;
        }

        public RationalNumber Add(RationalNumber x)
        {
            Numerator = Numerator * x.Denominator + x.Numerator * Denominator;
            Denominator = Denominator * x.Denominator;

            return new RationalNumber(Numerator, Denominator);
        }

        public RationalNumber Subtract(RationalNumber x)
        {
            Numerator = Numerator * x.Denominator - x.Numerator * Denominator;
            Denominator = Denominator * x.Denominator;

            return new RationalNumber(Numerator, Denominator);
        }

        public RationalNumber Multiply(RationalNumber x)
        {
            Numerator *= x.Numerator;
            Denominator *= x.Denominator;

            return new RationalNumber(Numerator, Denominator);
        }

        public RationalNumber Divide(RationalNumber x)
        {
            Numerator *= x.Denominator;
            Denominator *= x.Numerator;

            return new RationalNumber(Numerator, Denominator);
        }

        public double Compute() =>
            (double) Numerator / Denominator;
    }
}
