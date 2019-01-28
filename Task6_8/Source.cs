using System;
using System.Collections.Generic;

namespace Task6_8
{
    public class Source
    {
        public double Load { get; private set; }
        public double TotalPower { get; }
        public ElectricalLoad[] ElectricalLoads { get; }

        public Source(int numberOfSockets, double totalPower)
        {
            if (numberOfSockets <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numberOfSockets));
            }

            if (totalPower <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(totalPower));
            }

            TotalPower = totalPower;
            ElectricalLoads = new ElectricalLoad[numberOfSockets];
        }

        public void PlugIn(int socketNumber, ElectricalLoad electricalLoad)
        {
            if (socketNumber < 0 || socketNumber > ElectricalLoads.Length - 1)
            {
                throw new ArgumentOutOfRangeException(nameof(socketNumber));
            }

            if (electricalLoad == null)
            {
                throw new ArgumentOutOfRangeException(nameof(electricalLoad));
            }

            if (ElectricalLoads[socketNumber] != null)
            {
                Unplug(socketNumber);
            }

            if (CanPlugIn(electricalLoad))
            {
                ElectricalLoads[socketNumber] = electricalLoad;
                Load += electricalLoad.Power;
            }
        }

        private void Unplug(int socketNumber)
        {
            Load -= ElectricalLoads[socketNumber].Power;

            ElectricalLoads[socketNumber] = null;
        }

        private bool CanPlugIn(ElectricalLoad electricalLoad)
        {
            if (Load + electricalLoad.Power <= TotalPower)
            {
                return true;
            }

            return false;
        }
    }
}
