using System;

namespace Task4_3
{
    public class Angle
    {
        public double Radians { get; }        

        public Angle(double radians)
        {
            Radians = radians;
        }

        public Angle(int degree, int minutes, int seconds)
        {
            Radians = ConvertToRadians(degree, minutes, seconds);
        }

        public double MultiplyWith(double number) =>
            Radians * number;

        public double SumWith(Angle angle) => 
            Radians + angle.Radians;

        public static double ConvertToRadians(int degree, int minutes, int seconds)
        {
            if (degree < 0 && minutes < 0 && seconds < 0)
                throw new ArgumentOutOfRangeException("Invalid input.");

            const double FACTOR = Math.PI / 180;
            
            return FACTOR * (degree + minutes / 60 + seconds / 3600);
        }

    }
}
