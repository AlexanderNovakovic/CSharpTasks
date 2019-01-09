namespace Task4_7
{
    public class LinkedList
    {
        public Element Head { get; set; }

        public LinkedList()
        {

        }

        public LinkedList(int number)
        {
            Head = new Element(number); 
        }

        public void Clear() => 
            Head = null;

        public int Count()
        {
            int n = 0;

            for (Element element = Head; element != null; element = element.Next)
            {
                n++;
            }

            return n;
        }

        public void AddFirst(int number) => 
            Head = new Element(number, Head);

        public void AddLast(int number)
        {
            Element element = new Element(number);

            if (Head == null)
            {
                Head = element;
            }
            else
            {
                Element temp = Head;

                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = element;
            }
        }

        public void Insert(int number)
        {
            Element temp = Head;
            Element previous = null;

            while (temp != null && temp.Number < number)
            {
                previous = temp;
                temp = temp.Next;
            }

            Element element = new Element(number, temp);

            if (previous == null)
            {
                Head = element;
            }
            else
            {
                previous.Next = element;
            }
        }

        public void Remove(int number)
        {
            Element temp = Head;
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
                        Head = temp;
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
