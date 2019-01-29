using System.Collections.Generic;
using Xunit;
using static Task6_7.UnitTests.Builders.Builders;

namespace Task6_7.UnitTests
{
    public class ManagerTests
    {
        [Theory]
        [MemberData(nameof(AddTestParams))]
        public void AddTests(Manager manager, double expectedTotalSales, double expectedSalary)
        {
            Assert.Equal(expectedTotalSales, manager.TotalSales);
            Assert.Equal(expectedSalary, manager.Salary);
        }

        public static IEnumerable<object[]> AddTestParams()
        {
            yield return new object[]
            {
                AManager()
                    .WithSalesPercentage(10)
                    .WithEmployees(
                        AMerchant()
                            .WithSalesPercentage(5)
                            .WithSales(20),
                        AMerchant()
                            .WithSalesPercentage(6)
                            .WithSales(30)
                    ),
                ExpectedTotalSales(50),
                ExpectedSalary(5)
            };
        }
    }
}
