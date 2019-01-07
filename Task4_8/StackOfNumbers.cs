using System;

namespace Task4_8
{
    public class StackOfNumbers
    {
        public Element First { get; set; }
        public Element Last { get; set; }

        public void Push(int number)
        {
            Element element = new Element(number);

            if (First == null)
            {
                First = element;
            }
            else
            {
                Last.Next = element;
            }

            Last = element;
        }

        public int Pop()
        {
            if (First == null)
            {
                throw new ArgumentNullException("Stack is empty!");
            }

            int number = First.Number;

            if (First == null && First.Next == null)
            {
                Last = null;
            }

            return number;
        }

        public void EmptyStack()
        {
            First = null;
            Last = null;
        }        
    }
}
