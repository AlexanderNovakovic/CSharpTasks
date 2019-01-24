namespace Task6_5
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

        public Point Move(double dx, double dy) => 
            new Point(X + dx, Y + dy);
    }
}
