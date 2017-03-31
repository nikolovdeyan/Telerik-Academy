using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public interface IDrawable
    {
        // This interface allows bank accounts that implement it to draw money
        void DrawMoney(decimal amount);
    }
}
