namespace Task2_2
{
    public static class MathExtensions
    {
        public static double[] Sort(params double[] numbers)
        {         
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        double temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            return numbers;
        }
    }
}
