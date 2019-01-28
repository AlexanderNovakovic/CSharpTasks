using System;
using System.Collections.Generic;

namespace Task6_7
{
    public class Company
    {
        public double ProfitPercentage { get; }
        public List<Employee> Employees { get; }

        public double Profit
        {
            get
            {
                double totalIncome = 0;
                double totalSalary = 0;

                foreach (var employee in Employees)
                {
                    if (employee is Merchant)
                    {
                        totalIncome += employee.Income;                      
                    }

                    totalSalary += employee.Salary;
                }

                return totalIncome * ProfitPercentage / 100 - totalSalary;
            }
        }

        public Company(double profitPercentage, List<Employee> employees)
        {
            if (profitPercentage <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(profitPercentage));
            }
            
            ProfitPercentage = profitPercentage;
            Employees = employees;
        }

        public void Hire(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException();
            }

            Employees.Add(employee);            
        }

        public void Fire(int id)
        {
            if (id < 0 || id >= Employees.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }

            Employees.RemoveAt(id);
        }

        public double Profit2(double totalIncome, double totalSalary) =>
            totalIncome * ProfitPercentage / 100 - totalSalary;
    }
}
