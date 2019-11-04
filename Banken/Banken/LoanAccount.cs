using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class LoanAccount : BankAccount
    {
        private double _creditLimit;



        public override bool Withdraw(double amount)
        {
            if(amount < _creditLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override double CalculateRate()
        {
            return 2;
        }
    }
}
