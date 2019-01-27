using System;

namespace Task6_7
{
    public abstract class Employee : IEquatable<Employee>
    {
        public string Name { get; protected set; }
        public double SalaryPercentage { get; protected set; }
        public abstract double Income { get; }

        public double Salary => Income * SalaryPercentage / 100;

        protected Employee(string name, double salaryPercentage)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException();
            }

            if (salaryPercentage <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            Name = name;
            SalaryPercentage = salaryPercentage;
        }

        public bool Equals(Employee other)
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
            Equals(obj as Employee);

        public override int GetHashCode()
        {
            unchecked
            {
                return (Name.GetHashCode() * 397) ^ SalaryPercentage.GetHashCode() ^ Income.GetHashCode();
            }
        }
    }
}
