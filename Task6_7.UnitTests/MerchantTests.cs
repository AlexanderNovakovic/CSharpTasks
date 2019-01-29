using System.Collections.Generic;
using Xunit;
using static Task6_7.UnitTests.Builders.Builders;

namespace Task6_7.UnitTests
{
    public class MerchantTests
    {
        [Theory]
        [MemberData(nameof(SellTestParams))]
        public void SellTests(Merchant merchant, double expectedTotalSales, double expectedSalary)
        {
            Assert.Equal(expectedTotalSales, merchant.TotalSales);
            Assert.Equal(expectedSalary, merchant.Salary);
        }

        public static IEnumerable<object[]> SellTestParams()
        {
            yield return new object[]
            {
                AMerchant()
                    .WithSalesPercentage(5)
                    .WithSales(20.5, 30, 21.5),
                ExpectedTotalSales(20.5 + 30 + 21.5),
                ExpectedSalary(3.6)
            };
        }
    }
}
