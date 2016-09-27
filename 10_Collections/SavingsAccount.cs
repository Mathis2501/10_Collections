using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _10_Collections
{
    class SavingsAccount : Asset
    {
        public string AccountName;
        public double Value;
        public double InterestRate;

        public SavingsAccount(string SecondaryAccountName, double SecondaryValue, double SecondaryInterestRate)
        {
            AccountName = SecondaryAccountName;
            Value = SecondaryValue;
            InterestRate = SecondaryInterestRate;
        }

        public override string ToString()
        {
            return "SavingsAccount[value=" + Value.ToString("##.0").Replace(",", ".") + ",interestRate=" + InterestRate.ToString().Replace(",", ".") + "]";
        }

        public double GetValue()
        {
            return Value;
        }

        public void ApplyInterest()
        {
            Value *= (InterestRate / 100) + 1;
        }

        public string GetName()
        {
            return AccountName;
        }

    }
}
