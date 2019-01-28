namespace Task6_8
{
    public class ElectricalDevice : ElectricalLoad
    {
        private double _power;
        public string Name { get; }

        public override double Power => _power;

        public ElectricalDevice(string name, double power)
        {
            Name = name;
            _power = power;
        }
    }
}
