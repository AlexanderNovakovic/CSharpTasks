using System.Collections.Generic;
using Xunit;
using static System.Math;

namespace Task6_1.UnitTests
{
    public class BucketTests
    {
        [Theory]
        [MemberData(nameof(PourInTestParams))]
        public void PourInTests(Bucket bucket, double quantity, double expectedFillness)
        {
            bucket.PourIn(quantity);
            
            Assert.Equal(expectedFillness, bucket.Fillness);
        }

        public static IEnumerable<object[]> PourInTestParams()
        {
            yield return new object[]
            {
                new Bucket(1, 3, 4.42477796076938),
                Quantity(4),
                ExpectedFillness(8.42477796076938)
            };
        }

        [Theory]
        [MemberData(nameof(PourOutTestParams))]
        public void PourOutTests(Bucket bucket, double quantity, double expectedFillness)
        {
            bucket.PourOut(quantity);

            Assert.Equal(expectedFillness, Round(bucket.Fillness, 5));
        }

        public static IEnumerable<object[]> PourOutTestParams()
        {
            yield return new object[]
            {
                new Bucket(1, 3, 10),
                Quantity(5),
                ExpectedFillness(4.42478)
            };
        }

        [Theory]
        [MemberData(nameof(PourFromTestParams))]
        public void PourFromTests(Bucket first, Bucket second, double expectedFillnessFirst, double expectedFillnessSecond)
        {
            second.PourFrom(first);

            Assert.Equal(expectedFillnessFirst, Round(first.Fillness, 5));
            Assert.Equal(expectedFillnessSecond, Round(second.Fillness, 5));
        }

        public static IEnumerable<object[]> PourFromTestParams()
        {
            yield return new object[]
            {
                new Bucket(1, 3, 10),
                new Bucket(0.6, 5, 0),
                ExpectedFillnessFirst(3.76991),
                ExpectedFillnessSecond(5.65487)
            };
        }

        public static double Quantity(double quantity) => quantity;
        public static double ExpectedFillness(double expectedFillness) => expectedFillness;
        public static double ExpectedFillnessFirst(double fillnessFirst) => fillnessFirst;
        public static double ExpectedFillnessSecond(double fillnessSecond) => fillnessSecond;
    }
}
