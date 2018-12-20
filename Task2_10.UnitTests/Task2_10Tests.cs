using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static Task2_10.DateExtensions;

namespace Task2_10.UnitTests
{
    public class Task2_10Tests
    {
        [Theory]
        [MemberData(nameof(DateTestsParams))]
        public void DateTests(int year, int month, int day, DateTime expected)
        {
            Assert.Equal(expected, NextDate(year, month, day));            
        }

        public static IEnumerable<object[]> DateTestsParams()
        {
            yield return new object[]
            {
                2016,
                10,
                2,
                new DateTime(2016, 10, 3)
            };

            yield return new object[]
            {
                2016,
                12,
                31,
                new DateTime(2017, 1, 1)
            };
        }
    }
}
