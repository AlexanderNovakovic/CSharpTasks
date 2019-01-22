using System.Collections.Generic;
using Xunit;
using static System.Math;

namespace Task6_1.UnitTests
{
    public class BucketTests
    {
        [Theory]
        [MemberData(nameof(PourInTestParams))]
        public void PourInTests(Bucket bucket, double toPourIn, double expectedVolumeFilled)
        {
            bucket.PourIn(toPourIn);
            
            Assert.Equal(expectedVolumeFilled, bucket.VolumeFilled);
        }

        public static IEnumerable<object[]> PourInTestParams()
        {
            yield return new object[]
            {
                new Bucket(1, 3, 4.42477796076938),
                PourIn(4),
                ExpectedVolumeFilled(8.42477796076938)
            };
        }

        [Theory]
        [MemberData(nameof(PourOutTestParams))]
        public void PourOutTests(Bucket bucket, double toPourOut, double expectedVolumeFilled)
        {
            bucket.PourOut(toPourOut);

            Assert.Equal(expectedVolumeFilled, Round(bucket.VolumeFilled, 5));
        }

        public static IEnumerable<object[]> PourOutTestParams()
        {
            yield return new object[]
            {
                new Bucket(1, 3, 10),
                PourOut(5),
                ExpectedVolumeFilled(4.42478)
            };
        }

        [Theory]
        [MemberData(nameof(PourFromTestParams))]
        public void PourFromTests(Bucket first, Bucket second, double expectedVolumeFilledFirst, double expectedVolumeFilledSecond)
        {
            second.PourFrom(first);

            Assert.Equal(expectedVolumeFilledFirst, Round(first.VolumeFilled, 5));
            Assert.Equal(expectedVolumeFilledSecond, Round(second.VolumeFilled, 5));
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

        public static double PourIn(double quantity) => quantity;
        public static double PourOut(double quantity) => quantity;
        public static double ExpectedVolumeFilled(double expectedFullness) => expectedFullness;
        public static double ExpectedFullnessFirst(double fullnessFirst) => fullnessFirst;
        public static double ExpectedFullnessSecond(double fullnessSecond) => fullnessSecond;
    }
}
