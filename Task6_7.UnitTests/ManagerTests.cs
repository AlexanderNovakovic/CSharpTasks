using System.Collections.Generic;
using Xunit;

namespace Task6_7.UnitTests
{
    public class ManagerTests
    {
        [Theory]
        [MemberData(nameof(AddTestParams))]
        public void AddTests(List<Merchant> merchants, Manager manager, double expectedIncome, double expectedSalary)
        {
            foreach (Merchant merchant in merchants)
            {
                manager.AddMerchant(merchant);
            }

            for (int i = 0; i < merchants.Count; i++)
            {
                Assert.True(merchants[i] == manager.Merchants[i]);
            }

            Assert.Equal(expectedIncome, manager.Income);
            Assert.Equal(expectedSalary, manager.Salary);
        }

        public static IEnumerable<object[]> AddTestParams()
        {
            yield return new object[]
            {
                new List<Merchant>()
                {
                    new Merchant("Marko", 5, 20),
                    new Merchant("Zoran", 6, 30)
                },
                new Manager("Nenad", 10, new List<Merchant>()),
                ExpectedIncome(50),
                ExpectedSalary(5)
            };
        }

        public static double ExpectedIncome(double income) => income;
        public static double ExpectedSalary(double salary) => salary;
    }
}
