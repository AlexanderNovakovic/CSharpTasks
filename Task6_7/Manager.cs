using System;
using System.Collections.Generic;

namespace Task6_7
{
    public class Manager : Employee, IEquatable<Manager>
    {
        public List<Merchant> Merchants { get; }

        public override double Income
        {
            get
            {
                double income = 0;

                for (int i = 0; i < Merchants.Count; i++)
                {
                    income += Merchants[i].Income;
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

        public bool Equals(Manager other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Name == other.Name
                   && SalaryPercentage == other.SalaryPercentage
                   && Income == other.Income;
        }

        public override bool Equals(object obj) =>
            Equals(obj as Manager);

        public override int GetHashCode()
        {
            unchecked
            {
                return (Name.GetHashCode() * 397) ^ SalaryPercentage.GetHashCode() ^ Income.GetHashCode();
            }
        }
    }
}
