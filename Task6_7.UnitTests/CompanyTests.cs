using System.Collections.Generic;
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
                new Company(20, new List<Employee>
                {
                    new Manager("Vesic", 10, new List<Merchant>
                    {
                        new Merchant("Dzoni", 5, 50)
                    }),
                    new Merchant("Dzoni", 5, 50)
                }), 
                new List<Employee> 
                {
                    new Manager("Nenad", 10, new List<Merchant>
                    {
                        new Merchant("Marko", 5, 20),
                        new Merchant("Zoran", 5, 30)
                    }),
                    new Merchant("Marko", 5, 20),
                    new Merchant("Zoran", 5, 30),
                    new Merchant("Goran", 5, 30),
                    new Manager("Pera", 10, new List<Merchant>())
                },
                ExpectedEmployees(new List<Employee>
                {
                    new Manager("Vesic", 10, new List<Merchant>
                    {
                        new Merchant("Dzoni", 5, 50)
                    }),
                    new Merchant("Dzoni", 5, 50),
                    new Manager("Nenad", 10, new List<Merchant>
                    {
                        new Merchant("Marko", 5, 20),
                        new Merchant("Zoran", 5, 30)
                    }),
                    new Merchant("Marko", 5, 20),
                    new Merchant("Zoran", 5, 30),
                    new Merchant("Goran", 5, 30),
                    new Manager("Pera", 10, new List<Merchant>())
                }),
                ExpectedProfit(9.5)
            };
        }

        [Theory]
        [MemberData(nameof(FireTestParams))]
        public void FireTests(Company company, int id, List<Employee> expectedEmployees)
        {
            company.Fire(id);

            for (int i = 0; i < expectedEmployees.Count; i++)
            {
                Assert.True(expectedEmployees[i].Equals(company.Employees[i]));
            }
        }

        public static IEnumerable<object[]> FireTestParams()
        {
            yield return new object[]
            {
                new Company(20, new List<Employee>
                {
                    new Manager("Vesic", 10, new List<Merchant>
                    {
                        new Merchant("Dzoni", 5, 50)
                    }),
                    new Merchant("Dzoni", 5, 50),
                    new Manager("Nenad", 10, new List<Merchant>
                    {
                        new Merchant("Marko", 5, 20),
                        new Merchant("Zoran", 5, 30)
                    }),
                    new Merchant("Marko", 5, 20),
                    new Merchant("Zoran", 5, 30),
                    new Merchant("Goran", 5, 30),
                    new Manager("Pera", 10, new List<Merchant>())
                }),
                Id(3),
                ExpectedEmployees(new List<Employee>
                {
                    new Manager("Vesic", 10, new List<Merchant>
                    {
                        new Merchant("Dzoni", 5, 50)
                    }),
                    new Merchant("Dzoni", 5, 50),
                    new Manager("Nenad", 10, new List<Merchant>
                    {
                        new Merchant("Marko", 5, 20),
                        new Merchant("Zoran", 5, 30)
                    }),
                    new Merchant("Zoran", 5, 30),
                    new Merchant("Goran", 5, 30),
                    new Manager("Pera", 10, new List<Merchant>())
                })
            };
        }

        public static List<Employee> ExpectedEmployees(List<Employee> employees) => employees;
        public static double ExpectedProfit(double profit) => profit;
        public static int Id(int id) => id;
    }
}
