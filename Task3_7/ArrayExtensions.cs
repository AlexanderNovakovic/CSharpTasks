namespace Task3_7
{
    public static class ArrayExtensions
    {
        public static int[] Sort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            return numbers;
        }

        public static int[] InsertionSort(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = i - 1; j >= 0 && numbers[j] > numbers[j + 1]; j--)
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }

            return numbers;
        }
    }
}
