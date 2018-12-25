using System;

namespace Task3_6
{
    public static class ArrayExtensions
    {
        public static int[] MergeTwoArraysAscending(int[] first, int[] second)
        {
            if (first.Length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(first));
            }

            if (second.Length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(second));
            }

            int[] third = new int[first.Length + second.Length];
            int indexOfFirst = 0;
            int indexOfSecond = 0;
            int indexOfThird = 0;

            while (indexOfFirst < first.Length && indexOfSecond < second.Length)
            {
                if (first[indexOfFirst] <= second[indexOfSecond])
                {
                    third[indexOfThird++] = first[indexOfFirst++];
                }
                else
                {
                    third[indexOfThird++] = second[indexOfSecond++];
                }
            }

            while (indexOfFirst < first.Length)
            {
                third[indexOfThird++] = first[indexOfFirst++];
            }

            while (indexOfSecond < second.Length)
            {
                third[indexOfThird++] = second[indexOfSecond++];                
            }

            return third;
        }
    }
}
