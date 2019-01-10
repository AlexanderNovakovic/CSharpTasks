using System.Collections;
using System.Collections.Generic;

namespace Task5_1
{
    public class Circles : IEnumerable<Circle>
    {
        private List<Circle> CircleList { get; }

        public Circles() => 
            CircleList = new List<Circle>();

        public void Add(Circle circle)
        {
            if (!CanAdd(circle))
            {
                return;
            }

            CircleList.Add(circle);
        }

        public bool CanAdd(Circle circle)
        {
            foreach (var c in CircleList)
            {
                if (c.IsOverlapping(circle))
                    return false;
            }

            return true;
        }

        public void Remove(Circle circle) => 
            CircleList.Remove(circle);

        public bool Contains(Circle circle) =>
            CircleList.Contains(circle);

        public IEnumerator<Circle> GetEnumerator() => 
            CircleList.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => 
            GetEnumerator();
    }
}
