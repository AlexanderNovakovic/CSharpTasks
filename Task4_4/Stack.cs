using System.Collections.Generic;

namespace Task4_4
{
    public class Stack
    {
        public List<int> List { get; set; }

        public Stack()
        {
            List = new List<int>(10);
        }

        public Stack(int peek)
        {
            List = new List<int>(peek);
        }

        public void Push(int number) => 
            List.Insert(0, number);

        public void Pop() => 
            List.RemoveAt(0);

        public int NumberOfElements() => 
            List.Count;

        public int Peek() => 
            List[0];
    }
}
