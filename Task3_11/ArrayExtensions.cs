namespace Task3_11
{
    public static class ArrayExtensions
    {
        public static int[][] TriangleMatrix(int[,] matrix)
        {
            int[][] triangleMatrix = new int[matrix.GetLength(0)][];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                triangleMatrix[i] = new int[i + 1];

                for(int j = 0; j <= i; j++)
                {
                    triangleMatrix[i][j] = matrix[i, j];
                }
            }

            return triangleMatrix;
        }
    }
}
