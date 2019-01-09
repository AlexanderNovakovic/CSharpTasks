namespace Task4_7
{
    public class Element
    {
        public int Number { get; set; }
        public Element Next { get; set; }

        public Element(int number)
        {
            Number = number;
            Next = null;
        }

        public Element(int number, Element next)
        {
            Number = number;
            Next = next;
        }
    }
}
