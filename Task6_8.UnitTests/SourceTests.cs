using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Task6_8.UnitTests
{
    public class SourceTests
    {
        [Theory]
        [MemberData(nameof(PlugInTestParams))]
        public void PlugInTests(Source source, List<ElectricalLoad> electricalLoads, double expectedLoad)
        {
            for (int i = 0; i < electricalLoads.Count; i++)
            {
                source.PlugIn(i, electricalLoads[i]);                
            }

            Assert.Equal(expectedLoad, source.Load);
        }

        public static IEnumerable<object[]> PlugInTestParams()
        {
            yield return new object[]
            {
                new Source(5, 1000),
                new List<ElectricalLoad>()
                {
                    new ElectricalDevice("sijalica", 100),
                    new ElectricalLoadGroup(new List<ElectricalLoad>()
                    {
                        new ElectricalDevice("tv", 300),
                        new ElectricalDevice("radio", 150)
                    })                    
                },
                ExpectedLoad(550)
            };
        }

        public static double ExpectedLoad(double power) => power;
    }
}
