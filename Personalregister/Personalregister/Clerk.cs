using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    class Clerk : Employed
    {
        double _income;

        public Clerk(string name, double income): base(name)
        {
            this._income = income;
        }

        public override double CalculateIncome()
        {
            return _income;
        }

        public override string ToString()
        {
            return $"{this.Name}(Kontorist)";
        }
        public override string PrintWithSalary(int income)
        {
            return $"{this.Name}(Kontorist): {income}";
        }
    }
}
