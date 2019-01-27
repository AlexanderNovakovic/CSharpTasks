using System.Collections.Generic;
using Xunit;

namespace Task6_7.UnitTests
{
    public class MerchantTests
    {
        [Theory]
        [MemberData(nameof(SellTestParams))]
        public void SellTests(Merchant merchant, double[] SoldValues, double expectedIncome, double expectedSalary)
        {
            foreach (double value in SoldValues)
            {
                merchant.Sell(value);
            }

            Assert.Equal(expectedIncome, merchant.Income);
            Assert.Equal(expectedSalary, merchant.Salary);
        }

        public static IEnumerable<object[]> SellTestParams()
        {
            yield return new object[]
            {
                new Merchant("Nenad", 5, 72),
                SoldValues(new double[] {20.5, 30, 21.5}),
                ExpectedIncome(72),
                ExpectedSalary(3.6)
            };
        }

        public static double[] SoldValues(double[] values) => values;
        public static double ExpectedIncome(double income) => income;
        public static double ExpectedSalary(double salary) => salary;
    }
}
