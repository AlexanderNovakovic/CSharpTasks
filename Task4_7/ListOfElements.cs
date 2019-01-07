namespace Task4_7
{
    public class ListOfElements
    {
        public Element First { get; set; }

        public ListOfElements()
        {

        }

        public ListOfElements(int number)
        {
            First = new Element(number); 
        }

        public void EmptyList() => 
            First = null;

        public int Size()
        {
            int n = 0;

            for (Element element = First; element != null; element = element.Next)
            {
                n++;
            }

            return n;
        }

        public void AddFirst(int number) => 
            First = new Element(number, First);

        public void AddLast(int number)
        {
            Element element = new Element(number);

            if (First == null)
            {
                First = element;
            }
            else
            {
                Element temp = First;

                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = element;
            }
        }

        public void Insert(int number)
        {
            Element temp = First;
            Element previous = null;

            while (temp != null && temp.Number < number)
            {
                previous = temp;
                temp = temp.Next;
            }

            Element element = new Element(number, temp);

            if (previous == null)
            {
                First = element;
            }
            else
            {
                previous.Next = element;
            }
        }

        public void Remove(int number)
        {
            Element temp = First;
            Element previous = null;

            while (temp != null)
            {
                if (temp.Number != number)
                {
                    previous = temp;
                    temp = temp.Next;
                }
                else
                {
                    temp = temp.Next;
                    if (previous == null)
                    {
                        First = temp;
                    }
                    else
                    {
                        previous.Next = temp;
                    }
                }
            }
        }
    }
}
