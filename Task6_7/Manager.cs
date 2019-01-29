using System;
using System.Collections.Generic;

namespace Task6_7
{
    public class Manager : Employee
    {
        private List<Employee> Employees { get; }

        public override double TotalSales
        {
            get
            {
                double income = 0;

                foreach (var merchant in Employees)
                {
                    income += merchant.TotalSales;
                }

                return income;
            }
            protected set
            {

            }
        }
        
        public Manager(string name, double salesPercentage) : base(name, salesPercentage)
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException();
            }

            Employees.Add(employee);
        }
    }
}
