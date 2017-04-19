using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public abstract class Account : IAccount
    {
        private ICustomer owner;
        private decimal balance;
        private decimal interestRate;

        public Account(ICustomer owner, decimal interestRate, decimal balance = 0.00M)
        {
            this.Owner = owner;
            this.InterestRate = interestRate;
            this.Balance = balance;
        }

        public ICustomer Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                this.owner = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                if (interestRate > 1)
                {
                    throw new ArgumentOutOfRangeException("Monthly interest rate is too high!");
                }
                else if (interestRate < 0)
                {
                    throw new ArgumentOutOfRangeException("Monthly interest rate can not be negative!");
                }

                this.interestRate = value;
            }
        }

        // The common case for interest amount calculation is here.
        // It is overriden for more specific cases in the children classes.
        public virtual decimal CalculateInterestAmount(int duration)
        {
            decimal interest = this.InterestRate * duration;
            return interest;
        }

    }
}
