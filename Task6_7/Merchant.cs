using System;

namespace Task6_7
{
    public class Merchant : Employee
    {
        private double _income;
        public double TotalSales { get; private set; }

        public override double Income => _income;   

        public Merchant(string name, double salaryPercentage, double income) : base(name, salaryPercentage)
        {
            Name = name;
            SalaryPercentage = salaryPercentage;
            _income = income;
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

