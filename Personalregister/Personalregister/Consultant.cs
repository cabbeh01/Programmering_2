using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    class Consultant : Employed
    {
        double _workedHour;
        double _hourly;

        public Consultant(string name, double workedhour, double hourly) : base(name)
        {
            this._workedHour = workedhour;
            this._hourly = hourly;
        }

        public override double CalculateIncome()
        {
            return _workedHour * _hourly;

        }
        public override string ToString()
        {
            return $"{this.Name}(Konsult)";
        }

        public override string PrintWithSalary(int income)
        {
            return $"{this.Name}(Konsult): {income}";
        }
    }
}
