namespace Task6_7.UnitTests.Builders
{
    public class ManagerBuilder
    {
        private string _name = "Manager";
        private double _salesPercentage = 0;
        private Employee[] _employees = new Employee[0];

        public ManagerBuilder WithSalesPercentage(double salesPercentage)
        {
            _salesPercentage = salesPercentage;
            return this;
        }

        public ManagerBuilder WithEmployees(params Employee[] employees)
        {
            _employees = employees;
            return this;
        }

        public static implicit operator Manager(ManagerBuilder builder) =>
            builder.Build();

        private Manager Build()
        {
            Manager manager = new Manager(_name, _salesPercentage);
            foreach (Employee employee in _employees)
            {
                manager.AddEmployee(employee);
            }

            return manager;
        }
    }
}
