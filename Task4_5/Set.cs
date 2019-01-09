namespace Task4_5
{
    public class Set
    {
        public double[] Arr { get; }

        public Set()
        {
            Arr = new double[0];
        }

        public Set(double[] numbers)
        {
            Arr = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                Arr[i] = numbers[i];
            }

            Sort(Arr);
        }

        private static void Sort(double[] numbers)
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
        }
    }
}
