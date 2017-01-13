using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public interface IAccount
    {
        // Common for all accounts and should be implemented by all.
        ICustomer Owner { get; set; }

        decimal Balance { get; set; }

        decimal InterestRate { get; set; }

        decimal CalculateInterestAmount(int months);
    }
}
