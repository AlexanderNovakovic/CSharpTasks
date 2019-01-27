using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Task6_7.UnitTests
{
    public class CompanyTests
    {
        [Theory]
        [MemberData(nameof(HireTestParams))]
        public void HireTests(Company company, List<Employee> newEmployees, List<Employee> expectedEmployees, double expectedProfit)
        {
            foreach (Employee employee in newEmployees)
            {
                company.Hire(employee);
            }

            for (int i = 0; i < expectedEmployees.Count; i++)
            {
                Assert.True(expectedEmployees[i].Equals(company.Employees[i]));
            }

            Assert.Equal(expectedProfit, company.Profit);
        }

        public static IEnumerable<object[]> HireTestParams()
        {
            yield return new object[]
            {
                new Company(20, new List<Employee>()
                {
                    new Manager("Vesic", 10, new List<Merchant>()
                    {
                        new Merchant("Dzoni", 5, 50)
                    })
                }), 
                new List<Employee>() 
                {
                    new Manager("Nenad", 10, new List<Merchant>()
                    {
                        new Merchant("Marko", 5, 20),
                        new Merchant("Zoran", 5, 30)
                    }),
                    new Merchant("Goran", 5, 30),
                    new Manager("Pera", 10, new List<Merchant>())
                },
                ExpectedEmployees(new List<Employee>()
                {
                    new Manager("Vesic", 10, new List<Merchant>()
                    {
                        new Merchant("Dzoni", 5, 50)
                    }),
                    new Manager("Nenad", 10, new List<Merchant>()
                    {
                        new Merchant("Marko", 5, 20),
                        new Merchant("Zoran", 5, 30)
                    }),
                    new Merchant("Goran", 5, 30),
                    new Manager("Pera", 10, new List<Merchant>())
                }),
                ExpectedProfit(9.5)
            };
        }

        public static List<Employee> ExpectedEmployees(List<Employee> employees) => employees;
        public static double ExpectedProfit(double profit) => profit;
    }
}
