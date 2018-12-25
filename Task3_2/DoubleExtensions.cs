namespace Task3_2
{
    public static class DoubleExtensions
    {
        public static double Average(int[] numbers)
        {
            double sum = 0;
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
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
    }
}
