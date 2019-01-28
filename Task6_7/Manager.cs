using System;
using System.Collections.Generic;

namespace Task6_7
{
    public class Manager : Employee
    {
        public List<Merchant> Merchants { get; }

        public override double Income
        {
            get
            {
                double income = 0;

                foreach (var merchant in Merchants)
                {
                    income += merchant.Income;
                }

                return income;
            }
        }
        
        public Manager(string name, double salaryPercentage, List<Merchant> merchants) : base(name, salaryPercentage)
        {
            Merchants = merchants;
        }

        public void AddMerchant(Merchant merchant)
        {
            if (merchant == null)
            {
                throw new ArgumentNullException();
            }

            Merchants.Add(merchant);
        }
    }
}

