using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    class Employed
    {
        string _name;
        public Employed(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get
            {
                return this._name;
            }
        }

        public virtual double CalculateIncome()
        {
            return 0;
        }
        public virtual string PrintWithSalary(int income)
        {
            return $"{income * 0}";
        }

        public override string ToString()
        {
            return "Du är anställd och inget mer!";
        }
    }
}
