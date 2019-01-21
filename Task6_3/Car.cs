using System;

namespace Task6_3
{
    public class Car : Vehicle
    {
        public int MaxNumberOfPassangers { get; }
        public int PassangerCounter { get; private set; }
        public double TotalWeight { get; private set; }
        public Car(int maxNumberOfPassangers, double weight, double maxWeight) : base(weight, maxWeight)
        {
            MaxNumberOfPassangers = maxNumberOfPassangers;
            PassangerCounter = 0;
            TotalWeight = weight;
        }

        public override void AddWeight(double passangerWeight)
        {
            if (passangerWeight <= 0 || Weight + passangerWeight >= MaxWeight || PassangerCounter > MaxNumberOfPassangers)
            {
                throw new ArgumentException();
            }

            TotalWeight += passangerWeight;
            PassangerCounter++;
        }
    }
}
