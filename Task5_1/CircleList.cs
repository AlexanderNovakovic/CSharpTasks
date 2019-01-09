using System;
using System.Collections.Generic;

namespace Task5_1
{
    public class CircleList
    {
        public List<Circle> Circles { get; }

        public CircleList()
        {
            Circles = new List<Circle>();
        }

        public void Add(Circle newCircle)
        {
            newCircle.CircleList = this;

            Validate(newCircle);

            Circles.Add(newCircle);            
        }

        public void Remove(Circle circle)
        {
            if (Circles.Contains(circle))
            {
                Circles.Remove(circle);
            }
            else
            {
                throw new ArgumentException("CircleList doesn't contain that circle!");
            }
        }


        public void Validate(Circle newCicle)
        {
            foreach (var circle in Circles)
            {
                if (circle.Center.Distance(newCicle.Center) - newCicle.R - circle.R < 0)
                    throw new ArgumentException();
            }
        }
    }
}
