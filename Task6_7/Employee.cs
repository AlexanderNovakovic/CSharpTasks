using System;

namespace Task6_7
{
    public abstract class Employee
    {
        public abstract double TotalSales { get; protected set; }

        public string Name { get; }
        public double SalesPercentage { get; set; }
        public double Salary => TotalSales * SalesPercentage / 100;

        protected Employee(string name, double salesPercentage)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException();
            }

            if (salesPercentage <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            Name = name;
            SalesPercentage = salesPercentage;
        }
    }
}
