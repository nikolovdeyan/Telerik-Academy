using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public class CompanyCustomer : Customer, ICustomer
    {
        public CompanyCustomer(string name)
            : base(name)
        {
        }


    }
}
