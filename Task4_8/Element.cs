namespace Task4_8
{
    public class Element
    {
        public int Number { get; set; }
        public Element Next { get; set; }        

        public Element(int number, Element element = null)
        {
            Number = number;
            Next = element;
        }
    }
}
