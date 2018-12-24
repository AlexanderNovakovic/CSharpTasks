using System;

namespace Task3_2
{
    public static class DoubleExtensions
    {
        public static double Average(int[] numbers, int n)
        {
            Validate(numbers, n);

            double sum = 0;
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    sum += numbers[i];
                    counter++;
                }
            }

            if (counter != 0)
            {
                return sum / counter;
            }

            return 0;
        }

        private static void Validate(int[] numbers, int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            if (numbers.Length != n)
            {
                throw new ArgumentOutOfRangeException(nameof(numbers));
            }
        }
    }
}
