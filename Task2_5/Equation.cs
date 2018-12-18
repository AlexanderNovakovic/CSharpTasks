namespace Task2_5
{
    public class Equation
    {
        public double XMin { get; }
        public double XMax { get; }
        public double DX { get; }

        public Equation(double xMin, double xMax, double dX)
        {
            XMin = xMin;
            XMax = xMax;
            DX = dX;
        }        
    }
}
