using System.Collections.Generic;
using Xunit;
using static System.Math;

namespace Task6_1.UnitTests
{
    public class BucketTests
    {
        [Theory]
        [MemberData(nameof(PourInTestParams))]
        public void PourInTests(Bucket bucket, double quantity, double expectedFullness)
        {
            bucket.PourIn(quantity);
            
            Assert.Equal(expectedFullness, bucket.Fullness);
        }

        public static IEnumerable<object[]> PourInTestParams()
        {
            yield return new object[]
            {
                new Bucket(1, 3, 4.42477796076938),
                Quantity(4),
                ExpectedFullness(8.42477796076938)
            };
        }

        [Theory]
        [MemberData(nameof(PourOutTestParams))]
        public void PourOutTests(Bucket bucket, double quantity, double expectedFullness)
        {
            bucket.PourOut(quantity);

            Assert.Equal(expectedFullness, Round(bucket.Fullness, 5));
        }

        public static IEnumerable<object[]> PourOutTestParams()
        {
            yield return new object[]
            {
                new Bucket(1, 3, 10),
                Quantity(5),
                ExpectedFullness(4.42478)
            };
        }

        [Theory]
        [MemberData(nameof(PourFromTestParams))]
        public void PourFromTests(Bucket first, Bucket second, double expectedFullnessFirst, double expectedFullnessSecond)
        {
            second.PourFrom(first);

            Assert.Equal(expectedFullnessFirst, Round(first.Fullness, 5));
            Assert.Equal(expectedFullnessSecond, Round(second.Fullness, 5));
        }

        public static IEnumerable<object[]> PourFromTestParams()
        {
            yield return new object[]
            {
                new Bucket(1, 3, 10),
                new Bucket(0.6, 5, 0),
                ExpectedFullnessFirst(3.76991),
                ExpectedFullnessSecond(5.65487)
            };
        }

        public static double Quantity(double quantity) => quantity;
        public static double ExpectedFullness(double expectedFullness) => expectedFullness;
        public static double ExpectedFullnessFirst(double fullnessFirst) => fullnessFirst;
        public static double ExpectedFullnessSecond(double fullnessSecond) => fullnessSecond;
    }
}
