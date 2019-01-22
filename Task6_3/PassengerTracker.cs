using System;

namespace Task6_3
{
    internal class PassengerTracker
    {
        public int Capacity { get; }
        public int Count { get; private set; }

        public PassengerTracker(int capacity)
        {
            Capacity = capacity;
            Count = 0;
        }

        public void AddPassenger()
        {
            if (Count >= Capacity)
            {
                throw new ArgumentException();
            }

            Count++;
        }
    }
}
