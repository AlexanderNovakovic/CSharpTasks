using System;
using System.Collections.Generic;

namespace Task6_8
{
    public class ElectricalLoadGroup : ElectricalLoad
    {
        public List<ElectricalLoad> ElectricalLoads { get; }

        public override double Power
        {
            get
            {
                double power = 0;

                foreach (ElectricalLoad electricalLoad in ElectricalLoads)
                {
                    power += electricalLoad.Power;
                }

                return power;
            }
        }

        public ElectricalLoadGroup(List<ElectricalLoad> electricalLoads)
        {
            ElectricalLoads = electricalLoads;
        }

        public void Add(ElectricalLoad electricalLoad)
        {
            if (electricalLoad == null)
            {
                throw new ArgumentNullException(nameof(electricalLoad));
            }
            
            ElectricalLoads.Add(electricalLoad);
        }
    }
}
