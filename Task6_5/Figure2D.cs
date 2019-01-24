using System;

namespace Task6_5
{
    public class Figure2D
    {
        private IShape Shape { get; }

        public Point Center { get; }
        public double Perimeter => Shape.Perimeter;
        public double Area => Shape.Area;

        public Figure2D(Point center, IShape shape)
        {
            Center = center ?? throw new ArgumentNullException(nameof(center));
            Shape = shape ?? throw new ArgumentNullException(nameof(shape));
        }

        public Figure2D Move(double dx, double dy) =>
            new Figure2D(Center.Move(dx, dy), Shape);

    }
}
