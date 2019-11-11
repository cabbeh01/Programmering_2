using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class SavingAccount : BankAccount
    {
        public SavingAccount(string SocialNumber, double Balance, double Rate) : base(SocialNumber, Balance, Rate)
        {

        }
        public override bool Withdraw(double amount)
        {
            if (amount <= this._balance && amount >0)
            {
                this._balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override double CalculateRate()
        {
            return (1 + this._rate) * this._balance;
        }

        public override string ToString()
        {
            return $"Sparkonto {this._socialNumber}: {this._balance}";
        }
    }
}
