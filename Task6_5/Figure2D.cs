using System;

namespace Task6_5
{
    public class Figure2D
    {
        public Point Center { get; }
        public virtual double Perimiter { get; }
        public virtual double Area { get; }

        public Figure2D(Point center)
        {
            Center = center ?? throw new ArgumentNullException(nameof(center));
        }
    }
}
