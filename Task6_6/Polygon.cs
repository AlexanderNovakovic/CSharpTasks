namespace Task6_6
{
    public class Polygon : Polyline
    {
        public override double Length => 
            base.Length + new Distance(Points[0], Points[Points.Length - 1]).Length;

        public Polygon(Point[] points) : base(points)
        {
            
        }
    }
}
