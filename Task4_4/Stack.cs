using System;
using System.Collections.Generic;

namespace Task4_4
{
    public class Stack
    {
        private List<int> Values { get; }
        public int Count => Values.Count;

        public Stack() => 
            Values = new List<int>(10);
        
        public void Push(int value) => 
            Values.Add(value);

        public int Pop()
        {
            int value = Peek();

            Values.RemoveAt(Values.Count - 1);

            return value;
        }

        public int Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException();

            return Values[Values.Count - 1];
        }
    }
}
