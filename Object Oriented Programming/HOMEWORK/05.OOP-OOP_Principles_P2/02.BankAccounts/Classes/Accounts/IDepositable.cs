using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public interface IDepositable
    {
        // This interface allows bank accounts that implement it to deposit money
        void DepositMoney(decimal amount);
    }
}
