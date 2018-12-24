using System;

namespace Task3_3
{
    public static class DoubleExtensions
    {
        public static double Minimum(double[] numbers)
        {
            if (numbers.Length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numbers));
            }

            double min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }
    }
}
