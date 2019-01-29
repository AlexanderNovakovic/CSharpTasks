namespace Task6_7.UnitTests.Builders
{
    public class Builders
    {
        public static MerchantBuilder AMerchant() =>
            new MerchantBuilder();

        public static ManagerBuilder AManager() =>
            new ManagerBuilder();

        public static double ExpectedTotalSales(double totalSales) => totalSales;
        public static double ExpectedSalary(double salary) => salary;
    }
}
