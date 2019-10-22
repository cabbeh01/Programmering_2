using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    class Vender : Employed
    {
        double _provision;
        double _sales;

        public Vender(string name, double provision, double sales) : base(name)
        {
            this._provision = provision;
            this._sales = sales;
        }

        public override double CalculateIncome()
        {
            return _sales * (_provision / 100);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
