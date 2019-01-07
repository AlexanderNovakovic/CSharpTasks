using static System.Math;

namespace Task4_1
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distance(Point p) =>
            Sqrt(Pow(X - p.X, 2) + Pow(Y - p.Y, 2));
    }
}
