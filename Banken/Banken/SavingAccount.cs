using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class SavingAccount : BankAccount
    {
        public override bool Withdraw(double amount)
        {
            return true;
        }

        public override double CalculateRate()
        {
            return 2;
        }
    }
}
