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


        public LoanAccount(string SocialNumber, double Balance, double Rate, double creditLimit) : base(SocialNumber, Balance, Rate)
        {
            this._creditLimit = creditLimit;
        }
        public override bool Withdraw(double amount)
        {
            if(amount < _creditLimit && amount > 0)
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
            return (1-this._rate) * this._balance;
        }


        public override string ToString()
        {
            return $"Lånekonto {this._socialNumber}: {this._balance}";
        }
    }
}
