using static System.Math;

namespace Task4_1
{
    public class Point
    {
        public double X { get; }

        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distance(Point other) =>
            Sqrt(Pow(X - other.X, 2) + Pow(Y - other.Y, 2));
    }
}
