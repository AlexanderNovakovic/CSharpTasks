using System;

namespace Task6_4
{
    public class Object
    {
        public double Sigma { get; }

        public virtual double Volume { get; }
        public double Mass => Volume * Sigma;

        public Object(double sigma)
        {
            if (sigma < 0)
            {
                throw new ArgumentException();
            }

            Sigma = sigma;
        }
    }
}
