using System;

namespace Task3_4
{
    public static class MathExtensions
    {
        public static double[] Reverse(double[] numbers)
        {
            if (numbers.Length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numbers));
            }

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int j = numbers.Length - i - 1;                
                double temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;                
            }

            return numbers;
        }
    }
}
