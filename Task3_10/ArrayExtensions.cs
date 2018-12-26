namespace Task3_10
{
    public static class ArrayExtensions
    {
        public static int[,] Transpose(int[,] matrix)
        {
            int[,] transposedMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    transposedMatrix[i, j] = matrix[j, i];
                }
            }

            return transposedMatrix;
        }
    }
}
