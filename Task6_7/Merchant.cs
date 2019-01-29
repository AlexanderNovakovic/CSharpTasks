using System;

namespace Task6_7
{
    public class Merchant : Employee
    {
        public override double TotalSales { get; protected set; }

        public Merchant(string name, double salesPercentage) : base(name, salesPercentage)
        {
        }

        public void Sell(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            TotalSales += value;
        }
    }
}
