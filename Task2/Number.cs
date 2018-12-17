namespace Task2
{
    public class NumberExpression
    {
        public int First { get; }
        public int Second { get; }

        public NumberExpression(int first, int second)
        {
            First = first;
            Second = second;
        }

        public int Sum() => 
            First + Second;
    }
}
