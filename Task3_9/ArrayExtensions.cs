using System;

namespace Task3_9
{
    public static class ArrayExtensions
    {
        public static int[,] SwitchMinWithMax(int[,] matrix)
        {
            if (matrix.LongLength <= 0)
                throw new ArgumentOutOfRangeException(nameof(matrix));

            int min = matrix[0, 0];
            int max = min;
            int iMin = 0, jMin = 0, iMax = 0, jMax = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        iMin = i;
                        jMin = j;
                    }
                    else if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        iMax = i;
                        jMax = j;
                    }
                }
            }

            int temp = matrix[iMin, jMin];
            matrix[iMin, jMin] = matrix[iMax, jMax];
            matrix[iMax, jMax] = temp;

            return matrix;
        }
    }
}
