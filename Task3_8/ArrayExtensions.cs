namespace Task3_8
{
    public static class ArrayExtensions
    {
        public static int[] InsertArrayAtPossition(int[] first, int[] second, int position)
        {
            if (position < 0)
            {
                position = 0;
            }

            if (position > first.Length)
            {
                position = first.Length;
            }

            int[] merged = new int[first.Length + second.Length];
            int indexOfFirst = 0;
            int indexOfSecond = 0;
            int indexOfMerged = 0;
            
            while (indexOfFirst < position)
            {
                merged[indexOfMerged++] = first[indexOfFirst++];
            }

            while(indexOfSecond < second.Length)
            {
                merged[indexOfMerged++] = second[indexOfSecond++];
            }

            while(indexOfFirst < first.Length)
            {
                merged[indexOfMerged++] = first[indexOfFirst++];
            }

            return merged;
        }
    }
}
