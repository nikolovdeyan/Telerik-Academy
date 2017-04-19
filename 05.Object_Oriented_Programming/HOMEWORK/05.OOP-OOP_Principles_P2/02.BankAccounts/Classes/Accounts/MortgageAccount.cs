using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class MortgageAccount : Account, IAccount, IDepositable
    {
        private const int PrivateCustomerNoInterestPeriodMortgage = 6;
        private const int CompanyCustomerHalfInterestPeriodMortgage = 12;

        public MortgageAccount(ICustomer owner, decimal interestRate, decimal balance)
            :base(owner, interestRate, balance)
        {
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateInterestAmount(int duration)
        {
            if (this.Owner.GetType() == typeof(CompanyCustomer))
            {
                if (duration <= CompanyCustomerHalfInterestPeriodMortgage)
                {
                    return ((this.InterestRate / 2) * duration);
                }
                else
                {
                    return base.CalculateInterestAmount(duration);
                }
            }
            else if(this.Owner.GetType() == typeof(IndividualCustomer))
            {
                if (duration <= PrivateCustomerNoInterestPeriodMortgage)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestAmount(duration);
                }
            }
            else
            {
                throw new InvalidCastException("Provided customer type does not exist.");
            }
        }
    }
}
