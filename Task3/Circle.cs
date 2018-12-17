using static System.Math;

namespace Task3
{
    public class Circle
    {
        public double Radius { get; }

        public Circle(double radius) => 
            Radius = radius;

        public double Circumference() => 
            Round(2 * Radius * PI, 2);

        public double Area() => 
            Round((Pow(Radius, 2) * PI), 2);
    }
}
