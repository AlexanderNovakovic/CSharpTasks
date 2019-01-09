using static System.Math;

namespace Task5_1
{
    public class Point
    {
        public double X { get; }
        public double Y { get; }
        public double DistanceFromOrigin { get; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;

            double distanceFromOrigin = Sqrt(Pow(x, 2) + Pow(y, 2));
            DistanceFromOrigin = distanceFromOrigin;
        }

        public double Distance(Point point) => 
            Sqrt(Pow(X - point.X, 2) + Pow(Y - point.Y, 2));
    }
}
