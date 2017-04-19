using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class DepositAccount : Account, IAccount, IDepositable, IDrawable
    {
        private const decimal MinimalAmountForInterestDeposit = 1000M;
        public DepositAccount(ICustomer owner, decimal interestRate, decimal balance)
            :base(owner, interestRate, balance)
        {
        }

        public void DrawMoney(decimal amount)
        {
            this.Balance -= amount;
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateInterestAmount(int duration)
        {
            if (this.Balance > 0 && this.Balance <= MinimalAmountForInterestDeposit)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterestAmount(duration);
            }
        }
    }
}
