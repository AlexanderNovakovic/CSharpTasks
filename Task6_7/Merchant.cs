using System;

namespace Task6_7
{
    public class Merchant : Employee, IEquatable<Merchant>
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

        public bool Equals(Merchant other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Name == other.Name
                   && SalaryPercentage == other.SalaryPercentage
                   && Income == other.Income;
        }

        public override bool Equals(object obj) =>
            Equals(obj as Merchant);

        public override int GetHashCode()
        {
            unchecked
            {
                return (Name.GetHashCode() * 397) ^ SalaryPercentage.GetHashCode() ^ Income.GetHashCode();
            }
        }
    }
}
