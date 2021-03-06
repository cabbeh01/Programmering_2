﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    abstract class BankAccount
    {
        protected string _socialNumber;     // Personnummer
        protected double _balance;          // Behållning
        protected double _rate;             // Räntesats

        public BankAccount(string SocialNumber, double Balance, double Rate)
        {
            this._socialNumber = SocialNumber;
            this._balance = Balance;
            this._rate = Rate;
        }
        public double Balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                this._balance = value;
            }
        }

        public void Deposit(double amount)
        {
            this._balance += amount;
        }
        public virtual bool Withdraw(double amount)
        {
            return true;
        }

        public virtual double CalculateRate()
        {
            return 0;
        }

        public override string ToString()
        {
            return "BankAccount";
        }
    }
}
