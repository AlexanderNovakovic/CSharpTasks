using System;

namespace Task3_5
{
    public static class ArrayExtensions
    {
        public static int[] DetermineBinomialCoefficientsForGivenNumber(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            int[] binomialCoefficients = new int[n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                binomialCoefficients[i] = 1;

                for (int k = i - 1; k > 0; k--)
                {
                    binomialCoefficients[k] += binomialCoefficients[k - 1];
                }
            }

            return binomialCoefficients;
        }
    }
}
