using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public class IndividualCustomer : Customer, ICustomer
    {
        public IndividualCustomer (string name)
            : base(name)
        {
        }


    }
}
