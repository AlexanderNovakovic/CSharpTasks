using System;

namespace Task4_3
{
    public class Angle
    {
        private double Radians { get; }        

        public Angle(double radians) => 
            Radians = radians;

        public Angle(int degree, int minutes, int seconds)
        {
            if (degree < 0 || minutes < 0 || seconds < 0)
                throw new ArgumentOutOfRangeException("Invalid input.");

            const double factor = Math.PI / 180;
            
            Radians = factor * (degree + minutes / 60 + seconds / 3600);
        }

        public static Angle operator +(Angle first, Angle second) =>
            new Angle(first.Radians + second.Radians);

        public static Angle operator *(Angle angle, double factor) =>
            new Angle(angle.Radians * factor);

        public static implicit operator double(Angle angle) =>
            angle.Radians;

    }
}
