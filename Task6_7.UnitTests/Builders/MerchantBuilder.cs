namespace Task6_7.UnitTests.Builders
{
    public class MerchantBuilder
    {
        private string _name = "Salesman";
        private double _salesPercentage = 0;
        private double[] _sales = new double[0];

        public MerchantBuilder WithSalesPercentage(double salesPercentage)
        {
            _salesPercentage = salesPercentage;
            return this;
        }

        public MerchantBuilder WithSales(params double[] sales)
        {
            _sales = sales;
            return this;
        }

        public static implicit operator Merchant(MerchantBuilder builder) =>
            builder.Build();

        private Merchant Build()
        {
            Merchant merchant = new Merchant(_name, _salesPercentage);
            foreach (double sale in _sales)
            {
                merchant.Sell(sale);
            }

            return merchant;
        }
    }
}
