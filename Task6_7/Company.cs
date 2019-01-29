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
                double totalSales = 0;
                double totalSalary = 0;

                foreach (var employee in Employees)
                {
                    if (employee is Merchant)
                    {
                        totalSales += employee.TotalSales;                      
                    }

                    totalSalary += employee.Salary;
                }

                return totalSales * ProfitPercentage / 100 - totalSalary;
            }
        }

        public Company(List<Employee> employees, double profitPercentage)
        {
            if (profitPercentage <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(profitPercentage));
            }
            
            ProfitPercentage = profitPercentage;
            Employees = employees ?? throw new ArgumentNullException(nameof(employees));
        }

        public void Hire(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException();
            }

            Employees.Add(employee);            
        }

        public void Fire(int index)
        {
            if (index < 0 || index >= Employees.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            Employees.RemoveAt(index);
        }
    }
}
