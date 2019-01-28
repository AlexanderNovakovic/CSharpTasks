using System.Collections.Generic;
using Xunit;

namespace Task6_8.UnitTests
{
    public class ElectricalLoadGroupTests
    {
        [Theory]
        [MemberData(nameof(AddTestParams))]
        public void AddTests(ElectricalLoadGroup eGroup, ElectricalLoad electricalLoad, List<ElectricalLoad> electricalLoads, double expectedTotalPower)
        {
            eGroup.Add(electricalLoad);

            for (int i = 0; i < electricalLoads.Count; i++)
            {
                Assert.True(electricalLoads[i].Equals(eGroup.ElectricalLoads[i]));
            }
            
            Assert.Equal(expectedTotalPower, eGroup.Power);
        }

        public static IEnumerable<object[]> AddTestParams()
        {
            yield return new object[]
            {
                new ElectricalLoadGroup(new List<ElectricalLoad>()
                {
                    new ElectricalDevice("tv", 300),
                    new ElectricalDevice("radio", 150)
                }), 
                new ElectricalDevice("light bulb", 100),
                new List<ElectricalLoad>()
                {
                    new ElectricalDevice("tv", 300),
                    new ElectricalDevice("radio", 150),
                    new ElectricalDevice("light bulb", 100)
                },
                ExpectedTotalPower(550)
            };
        }

        public static double ExpectedTotalPower(double power) => power;
    }
}
