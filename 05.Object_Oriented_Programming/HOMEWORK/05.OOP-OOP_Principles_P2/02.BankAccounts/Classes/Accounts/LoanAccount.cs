using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class LoanAccount : Account, IAccount, IDepositable
    {
        private const int PrivateCustomerNoInterestPeriodLoans = 3;
        private const int CompanyCustomerNoInterestPeriodLoans = 2;

        public LoanAccount(ICustomer owner, decimal interestRate, decimal balance)
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
                if (duration <= PrivateCustomerNoInterestPeriodLoans)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestAmount(duration);
                }
            }
            else if(this.Owner.GetType() == typeof(IndividualCustomer))
            {
                if (duration <= CompanyCustomerNoInterestPeriodLoans)
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
