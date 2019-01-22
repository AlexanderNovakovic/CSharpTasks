using Xunit;


namespace Task6_3.UnitTests
{
    public class PassengerTrackerTests
    {
        [Theory]
        [InlineData(5, 3)]
        [InlineData(3, 3)]        
        [InlineData(5, 0)]        
        public void AddPassengerTests(int capacity, int numberOfpassengers)
        {
            PassengerTracker tracker = new PassengerTracker(capacity);

            for (int i = 0; i < numberOfpassengers; i++)
            {
                tracker.AddPassenger();
            }

            Assert.True(tracker.Count <= tracker.Capacity);
        }
    }
}
